using Microsoft.Data.SqlClient;
using System.Configuration;

namespace ServiceApp
{
    public partial class TaskForm : Form
    {
        Dictionary<string, object> fields;
        public TaskForm(Dictionary<string, object> fields)
        {
            this.fields = fields;
            InitializeComponent();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            if (fields != null)
            {
                nameText.Text = (string)fields["Name"];
                kindText.Text = (string)fields["DeviceKind"];
                priceText.Value = (int)fields["Price"];
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            if (fields != null)
                cmd.CommandText = $"UPDATE Task SET Name = N'{nameText.Text}', DeviceKind = N'{kindText.Text}', Price = {priceText.Value} WHERE ID = {fields["ID"]}";
            else
                cmd.CommandText = $"INSERT INTO Task (Name, DeviceKind, Price) VALUES (N'{nameText.Text}', N'{kindText.Text}', {priceText.Value})";
            Console.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
