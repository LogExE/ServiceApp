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
    public partial class DivisionForm : Form
    {
        Dictionary<string, object> fields;
        public DivisionForm(Dictionary<string, object> fields)
        {
            InitializeComponent();
            this.fields = fields;
        }

        private void DivisionForm_Load(object sender, EventArgs e)
        {
            if (fields != null)
            {
                nameText.Text = (string)fields["Name"];
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            if (fields != null)
                cmd.CommandText = $"UPDATE Division SET Name = N'{nameText.Text}' WHERE ID = {fields["ID"]}";
            else
                cmd.CommandText = $"INSERT INTO Division (Name) VALUES (N'{nameText.Text}')";
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
