using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
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
            "Задачи", "Задачи в работе", "Выполненные заказы", "Заказы : Задачи"
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
        }

        private Form GimmeTableForm(string name, int? id)
        {
            var typ = Type.GetType(nameof(ServiceApp) + "." + name + "Form");
            return Activator.CreateInstance(typ, new object[] { id } ) as Form;
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

            int idToUpdate = (int)mainDataGrid.SelectedRows[0].Cells[0].Value;
            var form = GimmeTableForm(table, idToUpdate);
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

            int idToDelete = (int)mainDataGrid.SelectedRows[0].Cells[0].Value;
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = $"DELETE FROM {table} WHERE ID = {idToDelete}";
            cmd.ExecuteNonQuery();
            AllRowsFromTableIntoGrid(table);
        }
    }
}
