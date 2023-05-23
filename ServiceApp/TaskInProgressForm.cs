using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace ServiceApp
{
    public partial class TaskInProgressForm : Form
    {
        Dictionary<string, object> fields;
        public TaskInProgressForm(Dictionary<string, object> fields)
        {
            InitializeComponent();
            this.fields = fields;
        }

        private void TaskInProgressForm_Load(object sender, EventArgs e)
        {
            if (fields != null)
            {
                otaskText.Value = (int)fields["OrderedTask"];
                employeeText.Value = (int)fields["Employee"];
                startDatePicker.Value = (DateTime)fields["StartDate"];
                statusText.Text = (string)fields["Status"];
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            SqlCommand cmd = con.CreateCommand();

            string date = startDatePicker.Value.ToString("yyyy-MM-dd");

            if (fields != null)
                cmd.CommandText = $"UPDATE TaskInProgress SET OrderedTask = {otaskText.Value}, Employee = {employeeText.Value}, StartDate = '{date}', Status = '{statusText.Text}' WHERE ID = {fields["ID"]}";
            else
                cmd.CommandText = $"INSERT INTO TaskInProgress (OrderedTask, Employee, StartDate, Status) VALUES ({otaskText.Value}, {employeeText.Value}, '{date}', N'{statusText.Text}')";
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
