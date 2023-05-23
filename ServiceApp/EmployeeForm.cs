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

namespace ServiceApp
{
    public partial class EmployeeForm : Form
    {
        Dictionary<string, object> fields;
        public EmployeeForm(Dictionary<string, object> fields)
        {
            this.fields = fields;
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            if (fields != null)
            {
                surnameText.Text = (string)fields["Surname"];
                nameText.Text = (string)fields["Name"];
                patronymicText.Text = (string)fields["Patronymic"];
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            if (fields != null)
                cmd.CommandText = $"UPDATE Employee SET Surname = N'{surnameText.Text}', Name = N'{nameText.Text}', Patronymic = N'{patronymicText.Text}' WHERE ID = {fields["ID"]}";
            else
                cmd.CommandText = $"INSERT INTO Employee (Surname, Name, Patronymic) VALUES (N'{surnameText.Text}', N'{nameText.Text}', N'{patronymicText.Text}')";
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
