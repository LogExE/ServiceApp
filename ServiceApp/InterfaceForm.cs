using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ServiceApp
{
    public partial class InterfaceForm : Form
    {
        bool admin;
        bool allowed = false;

        Dictionary<string, string> nameToTable = new Dictionary<string, string>()
        {
            {"Клиенты", "Client"},
            {"Устройства", "Device"},
            {"Виды обслуживания", "Task"},
            {"Работники", "Employee"},
            {"Подразделения", "Division"},
            {"Заказы", "Request"},
            {"Задачи", "OrderedTask"},
            {"Задачи в работе", "TaskInProgress"},
            {"Выполненные заказы", "FinishedRequest"},
            {"Клиенты : Устройства", "ClientDevice"},
            {"Работник : Подразделение", "EmployeeDivision"},
            {"Работник : Виды обслуживания", "EmployeeTask"},
            {"Заказы : Задачи", "RequestOrderedTask"},
            {"Пользователи", "AppUser"}
        };

        HashSet<string> freeToWrite = new HashSet<string>()
        {
            "Клиенты", "Клиенты : Устройства",
            "Задачи", "Задачи в работе",
            "Заказы", "Выполненные заказы", "Заказы : Задачи"
        };

        public InterfaceForm(bool admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            roleLabel.Text = "Вы зашли за " + (admin ? "администратора" : "приемщика заказов");

            tableComboBox.DataSource = nameToTable.Keys.ToList();
            tableComboBox.SelectedIndex = 0;
        }

        private void AllRowsFromTableIntoGrid(string table)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {table}";
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();

            var dt = new DataTable();
            var adapter = new SqlDataAdapter(cmd);
            mainDataGrid.DataSource = dt;
            adapter.Fill(dt);

            mainDataGrid.EndEdit();
        }

        private void tableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = (string)((ComboBox)sender).SelectedItem;
            AllRowsFromTableIntoGrid(nameToTable[text]);

            if (!admin && !freeToWrite.Contains(text))
            {
                addButton.Enabled = false;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
                allowed = false;
            }
            else
            {
                addButton.Enabled = true;
                allowed = true;
                if (mainDataGrid.SelectedRows.Count != 0)
                {
                    updateButton.Enabled = true;
                    deleteButton.Enabled = true;
                }
            }
        }

        private Form GimmeTableForm(string name, Dictionary<string, object> fields)
        {
            var typ = Type.GetType(nameof(ServiceApp) + "." + name + "Form");
            return Activator.CreateInstance(typ, new object[] { fields } ) as Form;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string table = nameToTable[(string)tableComboBox.SelectedItem];
            var form = GimmeTableForm(table, null);
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
                AllRowsFromTableIntoGrid(table);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string table = nameToTable[(string)tableComboBox.SelectedItem];
            int rows = mainDataGrid.SelectedRows.Count;
            if (rows != 1)
                return;

            Dictionary<string, object> fields = new Dictionary<string, object>();
            foreach (DataGridViewCell cell in mainDataGrid.SelectedRows[0].Cells)
                fields[mainDataGrid.Columns[cell.ColumnIndex].Name] = cell.Value;

            var form = GimmeTableForm(table, fields);
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
                AllRowsFromTableIntoGrid(table);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string table = nameToTable[(string)tableComboBox.SelectedItem];
            int rows = mainDataGrid.SelectedRows.Count;
            if (rows != 1)
                return;

            string idCol = (table == "FinishedRequest") ? "Request" : "ID";
            int idToDelete = (int)mainDataGrid.SelectedRows[0].Cells[idCol].Value;
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = $"DELETE FROM {table} WHERE {idCol} = {idToDelete}";
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            AllRowsFromTableIntoGrid(table);
        }

        private void mainDataGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (mainDataGrid.SelectedRows.Count == 0)
            {
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
            else if (allowed)
            {
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }
    }
}
