using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace ServiceApp
{
    public partial class EmployeeTaskForm : Form
    {
        Dictionary<string, object> fields;
        public EmployeeTaskForm(Dictionary<string, object> fields)
        {
            InitializeComponent();
            this.fields = fields;
        }

        private void EmployeeTaskForm_Load(object sender, EventArgs e)
        {
            if (fields != null)
            {
                empText.Value = (int)fields["Employee"];
                taskText.Value = (int)fields["Task"];
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            SqlCommand cmd = con.CreateCommand();

            if (fields != null)
                cmd.CommandText = $"UPDATE EmployeeTask SET Employee = {empText.Value}, Task = {taskText.Value} WHERE ID = {fields["ID"]}";
            else
                cmd.CommandText = $"INSERT INTO EmployeeTask (Employee, Task) VALUES ({empText.Value}, {taskText.Value})";
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
