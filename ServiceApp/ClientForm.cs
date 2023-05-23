using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace ServiceApp
{
    public partial class ClientForm : Form
    {
        Dictionary<string, object> fields;
        public ClientForm(Dictionary<string, object> fields)
        {
            this.fields = fields;
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            if (fields != null)
            {
                surnameText.Text = (string)fields["Surname"];
                nameText.Text = (string)fields["Name"];
                patronymicText.Text = (string)fields["Patronymic"];
                phoneText.Text = (string)fields["Phone"];
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            if (fields != null)
                cmd.CommandText = $"UPDATE Client SET Surname = N'{surnameText.Text}', Name = N'{nameText.Text}', Patronymic = N'{patronymicText.Text}', Phone = N'{phoneText.Text}' WHERE ID = {fields["ID"]}";
            else
                cmd.CommandText = $"INSERT INTO Client (Surname, Name, Patronymic, Phone) VALUES (N'{surnameText.Text}', N'{nameText.Text}', N'{patronymicText.Text}', N'{phoneText.Text}')";
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
