using Microsoft.Data.SqlClient;

namespace ServiceApp
{
    public partial class LoginForm : Form
    {
        SqlConnection con;
        public LoginForm(SqlConnection con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string login = loginText.Text;
            string pwd = pwdText.Text;

            var cmd = new SqlCommand
            {
                CommandText = $"SELECT Passwd FROM AppUser WHERE Login = '{login}'",
                Connection = con
            };
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

            cmd = new SqlCommand
            {
                CommandText = $"SELECT ID FROM AppUser WHERE Login = '{login}'",
                Connection = con
            };
            cmd.ExecuteNonQuery();
            int id = (int)cmd.ExecuteScalar();

            var frm = new InterfaceForm(con, id == 1)
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