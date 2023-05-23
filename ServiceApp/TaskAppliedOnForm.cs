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
    public partial class TaskAppliedOnForm : Form
    {
        public int result;
        public TaskAppliedOnForm()
        {
            InitializeComponent();
        }

        private void TaskAppliedOnForm_Load(object sender, EventArgs e)
        {

        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "tasks_applied_on";
            cmd.Parameters.Add(new SqlParameter("@start", startPick.Value));
            cmd.Parameters.Add(new SqlParameter("@end", endPick.Value));
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            result = (int)cmd.ExecuteScalar();
            DialogResult = DialogResult.OK;
        }
    }
}
