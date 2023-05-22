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
    public partial class DeviceForm : Form
    {
        Dictionary<string, object> fields;
        public DeviceForm(Dictionary<string, object> fields)
        {
            this.fields = fields;
            InitializeComponent();
        }
        private void DeviceForm_Load(object sender, EventArgs e)
        {

        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            if (fields != null)
                cmd.CommandText = $"UPDATE Device SET Name = N'{nameText.Text}', Kind = N'{kindText.Text}' WHERE ID = {fields["ID"]}";
            else
                cmd.CommandText = $"INSERT INTO Client (Name, Kind) VALUES (N'{nameText.Text}', N'{kindText.Text}')";
            Console.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
