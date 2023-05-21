using Microsoft.Data.SqlClient;
using System.Drawing;

namespace ServiceApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string connectionString = "Server=.\\SQLEXPRESS;Database=Servicc;Trusted_Connection=True;TrustServerCertificate=True";
            var con = new SqlConnection(connectionString);
            con.Open();
            Application.Run(new LoginForm(con));
            con.Close();
        }
    }
}