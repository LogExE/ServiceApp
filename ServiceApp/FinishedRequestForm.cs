using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace ServiceApp
{
    public partial class FinishedRequestForm : Form
    {
        Dictionary<string, object> fields;
        public FinishedRequestForm(Dictionary<string, object> fields)
        {
            InitializeComponent();
            this.fields = fields;
        }

        private void FinishedRequestForm_Load(object sender, EventArgs e)
        {
            if (fields != null)
            {
                reqText.Value = (int)fields["Request"];
                endDatePicker.Value = (DateTime)fields["Finish"];
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            SqlCommand cmd = con.CreateCommand();

            string date = endDatePicker.Value.ToString("yyyy-MM-dd");

            if (fields != null)
                cmd.CommandText = $"UPDATE FinishedRequest SET Request = {reqText.Value}, Finish = '{date}' WHERE Request = {fields["Request"]}";
            else
                cmd.CommandText = $"INSERT INTO FinishedRequest (Request, Finish) VALUES ({reqText.Value}, '{date}')";
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
