using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceApp
{
    public partial class InterfaceForm : Form
    {
        bool admin;
        SqlConnection con;

        Dictionary<string, string> nameToTable = new Dictionary<string, string>()
        {
            {"Клиент", "Client"},
            {"Устройство", "Device"},
            {"Вид обслуживания", "Task"},
            {"Работник", "Employee"},
            {"Подразделение", "Division"}
        };

        public InterfaceForm(SqlConnection con, bool admin)
        {
            this.con = con;
            this.admin = admin;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            roleLabel.Text = "Вы зашли за " + (admin ? "администратора" : "приемщика заказов");

            tableComboBox.DataSource = nameToTable.Keys.ToList();
            tableComboBox.SelectedIndex = 0;
        }

        private void AllRowsFromTableIntoGrid(string name)
        {
            var cmd = new SqlCommand
            {
                CommandText = $"SELECT * FROM {name}",
                Connection = con
            };
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
    }
}
