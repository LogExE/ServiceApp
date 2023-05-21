using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceApp
{
    public partial class InterfaceForm : Form
    {
        bool admin;
        SqlConnection con;
        DataTable dt;
        public InterfaceForm(SqlConnection con, bool admin)
        {
            this.con = con;
            this.admin = admin;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            roleLabel.Text = "Вы зашли за " + (admin ? "администратора" : "приемщика заказов");

            dt = new DataTable();
            mainDataGrid.DataSource = dt;
            mainDataGrid.EndEdit();
            Test();
        }

        private void Test()
        {
            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Client";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
        }
    }
}
