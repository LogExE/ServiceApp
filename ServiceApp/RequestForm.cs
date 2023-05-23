using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace ServiceApp
{
    public partial class RequestForm : Form
    {
        Dictionary<string, object> fields;
        public RequestForm(Dictionary<string, object> fields)
        {
            InitializeComponent();
            this.fields = fields;
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            if (fields != null)
            {
                clientText.Value = (int)fields["Client"];
                applyPicker.Value = (DateTime)fields["ApplyDate"];
                if (!DBNull.Value.Equals(fields["EstFinishDate"]))
                {
                    estFinPicker.Value = (DateTime)fields["EstFinishDate"];
                    checkEst.Checked = true;
                    estFinPicker.Enabled = true;
                }
                priceText.Value = (int)fields["Price"];
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            SqlCommand cmd = con.CreateCommand();

            string apdate = applyPicker.Value.ToString("yyyy-MM-dd");
            string estpart = !checkEst.Checked ? "null" : $"'{estFinPicker.Value.ToString("yyyy-MM-dd")}'";

            if (fields != null)
                cmd.CommandText = $"UPDATE Request SET Client = {clientText.Value}, ApplyDate = '{apdate}', EstFinishDate = {estpart}, Price = {priceText.Value} WHERE ID = {fields["ID"]}";
            else
                cmd.CommandText = $"INSERT INTO Request (Client, ApplyDate, EstFinishDate, Price) VALUES ({clientText.Value}, '{apdate}', {estpart}, {priceText.Value})";
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void checkEst_CheckedChanged(object sender, EventArgs e)
        {
            estFinPicker.Enabled = !estFinPicker.Enabled;
        }
    }
}
