using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace ServiceApp
{
    public partial class OrderedTaskForm : Form
    {
        Dictionary<string, object> fields;
        public OrderedTaskForm(Dictionary<string, object> fields)
        {
            InitializeComponent();
            this.fields = fields;
        }

        private void OrderedTaskForm_Load(object sender, EventArgs e)
        {
            if (fields != null)
            {
                clientText.Value = (int)fields["ClientDevice"];
                taskText.Value = (int)fields["Task"];
                priceText.Value = (int)fields["Price"];
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            SqlCommand cmd = con.CreateCommand();

            if (fields != null)
                cmd.CommandText = $"UPDATE OrderedTask SET ClientDevice = {clientText.Value}, Task = {taskText.Value}, Price = {priceText.Value} WHERE ID = {fields["ID"]}";
            else
                cmd.CommandText = $"INSERT INTO OrderedTask (ClientDevice, Task, Price) VALUES ({clientText.Value}, {taskText.Value}, {priceText.Value})";
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
