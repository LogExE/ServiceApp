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
    public partial class ClientDeviceForm : Form
    {
        Dictionary<string, object> fields;
        public ClientDeviceForm(Dictionary<string, object> fields)
        {
            InitializeComponent();
            this.fields= fields;
        }
        
        private void ClientDeviceForm_Load(object sender, EventArgs e)
        {
            if (fields != null)
            {
                clientText.Value = (int)fields["Client"];
                deviceText.Value = (int)fields["Device"];
                stateText.Text = (string)fields["State"];
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            SqlCommand cmd = con.CreateCommand();

            if (fields != null)
                cmd.CommandText = $"UPDATE ClientDevice SET Client = {clientText.Value}, Device = {deviceText.Value}, State = N'{stateText.Text}' WHERE ID = {fields["ID"]}";
            else
                cmd.CommandText = $"INSERT INTO ClientDevice (Client, Device, State) VALUES ({clientText.Value}, {deviceText.Value}, N'{stateText.Text}')";
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }     
    }
}
