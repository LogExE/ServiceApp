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
    public partial class EmployeeDivisionForm : Form
    {
        Dictionary<string, object> fields;
        public EmployeeDivisionForm(Dictionary<string, object> fields)
        {
            InitializeComponent();
            this.fields = fields;
        }

        private void EmployeeDivisionForm_Load(object sender, EventArgs e)
        {
            if (fields != null)
            {
                empText.Value = (int)fields["Employee"];
                divText.Value = (int)fields["Division"];
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            SqlCommand cmd = con.CreateCommand();

            if (fields != null)
                cmd.CommandText = $"UPDATE EmployeeDivision SET Employee = {empText.Value}, Division = {divText.Value} WHERE ID = {fields["ID"]}";
            else
                cmd.CommandText = $"INSERT INTO EmployeeDivision (Employee, Division) VALUES ({empText.Value}, {divText.Value})";
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
