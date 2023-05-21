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
    public partial class Form2 : Form
    {
        int usr_id;
        SqlConnection con;
        DataTable dt;
        public Form2(SqlConnection con, int id)
        {
            this.con = con;
            this.usr_id = id;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            mainDataGrid.DataSource = dt;
            mainDataGrid.EndEdit();

            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Client";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
        }
    }
}
