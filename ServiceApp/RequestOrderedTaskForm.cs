using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace ServiceApp
{
    public partial class RequestOrderedTaskForm : Form
    {
        Dictionary<string, object> fields;
        public RequestOrderedTaskForm(Dictionary<string, object> fields)
        {
            InitializeComponent();
            this.fields = fields;
        }

        private void RequestOrderedTaskForm_Load(object sender, EventArgs e)
        {
            if (fields != null)
            {

            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            SqlCommand cmd = con.CreateCommand();

            if (fields != null)
                cmd.CommandText = $"UPDATE RequestOrderedTask SET Request = {reqText.Value}, OrderedTask = {otaskText.Value} WHERE ID = {fields["ID"]}";
            else
                cmd.CommandText = $"INSERT INTO RequestOrderedTask (Request, OrderedTask) VALUES ({reqText.Value}, {otaskText.Value})";
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
