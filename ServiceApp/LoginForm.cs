using Microsoft.Data.SqlClient;
using System.Configuration;

namespace ServiceApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string login = loginText.Text;
            string pwd = pwdText.Text;

            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = $"SELECT Passwd FROM AppUser WHERE Login = '{login}'";
            cmd.ExecuteNonQuery();
            object ret = cmd.ExecuteScalar();

            if (ret == null)
            {
                MessageBox.Show("Такого пользователя нет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pwd.CompareTo(ret) != 0)
            {
                MessageBox.Show("Пароль неверный!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmd.CommandText = $"SELECT IsAdmin FROM AppUser WHERE Login = '{login}'";
            cmd.ExecuteNonQuery();
            bool isAdmin = (bool)cmd.ExecuteScalar();
            
            var frm = new InterfaceForm(isAdmin)
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}