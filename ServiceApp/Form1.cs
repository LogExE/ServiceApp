using Microsoft.Data.SqlClient;

namespace ServiceApp
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.\\SQLEXPRESS;Database=Servicc;Trusted_Connection=True;TrustServerCertificate=True");
            con.Open();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string login = loginText.Text;
            string pwd = pwdText.Text;

            var cmd = new SqlCommand();
            //TODO: maybe fix inject
            cmd.CommandText = "SELECT Passwd FROM AppUser WHERE Login = '" + login + "'";
            cmd.Connection = con;
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

            cmd = new SqlCommand();
            cmd.CommandText = "SELECT ID FROM AppUser WHERE Login = '" + login + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            int id = (int)cmd.ExecuteScalar();

            var frm = new Form2(con, id)
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
        }
    }
}