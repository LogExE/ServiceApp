using Azure.Core;
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
    public partial class AppUserForm : Form
    {
        Dictionary<string, object> fields;
        public AppUserForm(Dictionary<string, object> fields)
        {
            InitializeComponent();
            this.fields = fields;
        }

        private void AppUserForm_Load(object sender, EventArgs e)
        {
            if (fields != null)
            {
                loginText.Text = (string)fields["Login"];
                pwdText.Text = (string)fields["Passwd"];
                admCheck.Checked = (bool)fields["IsAdmin"];
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();

            string adm = admCheck.Checked ? "1" : "0";

            if (fields != null)
                cmd.CommandText = $"UPDATE AppUser SET Login = N'{loginText.Text}', Passwd = N'{pwdText.Text}', IsAdmin = {adm} WHERE ID = {fields["ID"]}";
            else
                cmd.CommandText = $"INSERT INTO AppUser (Login, Passwd, IsAdmin) VALUES (N'{loginText.Text}', N'{pwdText.Text}', {adm})";
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
