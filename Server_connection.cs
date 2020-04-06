using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_App
{
    class Server_connection
    {
        public static string string_connction = @"Data Source=DESKTOP-6MFL3EN\SQLEXPRESS;Initial Catalog=AccountDB;Integrated Security=True";

        public static DataTable executeSQL(string sql)
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter adapter = default(SqlDataAdapter);
            DataTable dt = new DataTable();
            try
            {
                con.ConnectionString = string_connction;
                con.Open();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);
                con.Close();
                con = null;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"An error occured: {ex.Message}", "SQL Server Connection Failed ", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                dt = null;
            }
            return dt;
        }
    }
}
