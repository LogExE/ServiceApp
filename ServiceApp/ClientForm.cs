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

namespace ServiceApp
{
    public partial class ClientForm : Form
    {
        int? id;
        public ClientForm(int? id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            if (id.HasValue)
                cmd.CommandText = $"UPDATE Client SET Surname = N'{surnameText.Text}', Name = N'{nameText.Text}', Patronymic = N'{patronymicText.Text}', Phone = N'{phoneText.Text}' WHERE ID = {id}";
            else 
                cmd.CommandText = $"INSERT INTO Client (Surname, Name, Patronymic, Phone) VALUES (N'{surnameText.Text}', N'{nameText.Text}', N'{patronymicText.Text}', N'{phoneText.Text}')";
            Console.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
