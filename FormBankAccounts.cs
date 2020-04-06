using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_App
{
    public partial class FormBankAccounts : Form
    {
        private string user_id;

        public FormBankAccounts(string user_id)
        {
            this.user_id = user_id;
            InitializeComponent();
        }

        private void FormBankAccounts_Load(object sender, EventArgs e)
        {
            string mySQL = string.Empty;
            mySQL += "SELECT  [AccountDB].[dbo].[Accounts].AccNumber, [AccountDB].[dbo].[Accounts].Firstname,[AccountDB].[dbo].[Accounts].Lastname,[AccountDB].[dbo].[Accounts].Summ, " +
                " [AccountDB].[dbo].[Accounts].Last_year FROM[AccountDB].[dbo].[Accounts] INNER JOIN[AccountDB].[dbo].[Usesr_Accounts]" +
                " ON[AccountDB].[dbo].[Accounts].AccNumber = [AccountDB].[dbo].[Usesr_Accounts].AccNumber WHERE[AccountDB].[dbo].[Usesr_Accounts].UserID = ";
            mySQL += user_id;
            DataTable userData = Server_connection.executeSQL(mySQL);
            if (userData.Rows.Count > 0)
            {
                dataGridViewBankAcc.DataSource = userData;
            }
            else
            {
                MessageBox.Show("This user does not have an account");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        { }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string mySQL = string.Empty;
            mySQL += "SELECT  [AccountDB].[dbo].[Accounts].AccNumber, [AccountDB].[dbo].[Accounts].Firstname,[AccountDB].[dbo].[Accounts].Lastname, " +
                " [AccountDB].[dbo].[Accounts].Last_year, FORMAT([AccountDB].[dbo].[Accounts].Summ, 'C', 'de-de') AS \"Sum on account\" FROM[AccountDB].[dbo].[Accounts] INNER JOIN[AccountDB].[dbo].[Usesr_Accounts]" +
                " ON[AccountDB].[dbo].[Accounts].AccNumber = [AccountDB].[dbo].[Usesr_Accounts].AccNumber WHERE[AccountDB].[dbo].[Usesr_Accounts].UserID = ";
            mySQL += user_id + " ORDER BY ";
            if (comboBoxSort.Text.Trim() == "Account Number")
            {
                mySQL += "[AccountDB].[dbo].[Accounts].AccNumber";
            }
            if (comboBoxSort.Text.Trim() == "Owner name")
            {
                mySQL += "[AccountDB].[dbo].[Accounts].Firstname";
            }
            if (comboBoxSort.Text.Trim() == "Owner surname")
            {
                mySQL += "[AccountDB].[dbo].[Accounts].Lastname";
            }
            if (comboBoxSort.Text.Trim() == "Last year")
            {
                mySQL += "[AccountDB].[dbo].[Accounts].Last_year";
            }
            if (comboBoxSort.Text.Trim() == "Sum on account")
            {
                mySQL += "\"Sum on account\"";
            }
            DataTable userData = Server_connection.executeSQL(mySQL);
            if (userData.Rows.Count > 0)
            {
                dataGridViewBankAcc.DataSource = userData;
            }
            else
            {
                MessageBox.Show("You should chooce by what value to sort");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string mySQL = string.Empty;
            mySQL += "SELECT  [AccountDB].[dbo].[Accounts].AccNumber, [AccountDB].[dbo].[Accounts].Firstname,[AccountDB].[dbo].[Accounts].Lastname, " +
                " [AccountDB].[dbo].[Accounts].Last_year, FORMAT([AccountDB].[dbo].[Accounts].Summ, 'C', 'de-de') AS \"Sum on account\" FROM[AccountDB].[dbo].[Accounts] INNER JOIN[AccountDB].[dbo].[Usesr_Accounts]" +
                " ON[AccountDB].[dbo].[Accounts].AccNumber = [AccountDB].[dbo].[Usesr_Accounts].AccNumber WHERE [AccountDB].[dbo].[Usesr_Accounts].UserID = ";
            mySQL += user_id + " AND [AccountDB].[dbo].[Usesr_Accounts].";
            if (comboBoxSearch.Text.Trim() == "Account Number")
            {
                mySQL += "AccNumber = " + txtSearch.Text.Trim();
            }
            if (comboBoxSearch.Text.Trim() == "Owner name")
            {
                mySQL += "Firstname = '" + txtSearch.Text.Trim() + "'";
            }
            if (comboBoxSearch.Text.Trim() == "Owner surname")
            {
                mySQL += "Lastname = '" + txtSearch.Text.Trim() + "'";
            }
            if (comboBoxSearch.Text.Trim() == "Last year")
            {
                mySQL += "Last_year = " + txtSearch.Text.Trim();
            }
            if (comboBoxSearch.Text.Trim() == "Sum on account")
            {
                mySQL += "Summ = " + txtSearch.Text.Trim();
            }
            DataTable userData = Server_connection.executeSQL(mySQL);
            if (userData.Rows.Count > 0)
            {
                dataGridViewBankAcc.DataSource = userData;
            }
            else
            {
                MessageBox.Show("No matches finded");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormAccSettings fas = new FormAccSettings(user_id);
            fas.ShowDialog();
        }

        private void dataGridViewBankAcc_CellValueChange(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewBankAcc.CurrentRow != null)
            {
                using (SqlConnection sql_conn = new SqlConnection(Server_connection.string_connction))
                {
                    sql_conn.Open();
                    DataGridViewRow dgvRow = dataGridViewBankAcc.CurrentRow;
                    SqlCommand sql_command = new SqlCommand("AccountAddOrEdit", sql_conn);
                    sql_command.CommandType = CommandType.StoredProcedure;
                    sql_command.Parameters.AddWithValue("@AccNumber", Convert.ToInt32(dgvRow.Cells["AccNumber"].Value));
                    sql_command.Parameters.AddWithValue("@Firstname", dgvRow.Cells["Firstname"].Value == DBNull.Value ? "" : dgvRow.Cells["Firstname"].Value.ToString());
                    sql_command.Parameters.AddWithValue("@Lastname", dgvRow.Cells["Lastname"].Value == DBNull.Value ? "" : dgvRow.Cells["Lastname"].Value.ToString());
                    sql_command.Parameters.AddWithValue("@Summ", Convert.ToInt32(dgvRow.Cells["Summ"].Value == DBNull.Value ? "0" : dgvRow.Cells["Summ"].Value));
                    sql_command.Parameters.AddWithValue("@Last_year", Convert.ToInt32(dgvRow.Cells["Last_year"].Value == DBNull.Value ? "0" : dgvRow.Cells["Last_year"].Value));
                    sql_command.ExecuteNonQuery();
                    FormBankAccounts fba = new FormBankAccounts(this.user_id);
                    fba.FormBankAccounts_Load(sender, e);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int row_index = dataGridViewBankAcc.CurrentCell.RowIndex;
            dataGridViewBankAcc.Rows.RemoveAt(row_index);
            using (SqlConnection sql_conn = new SqlConnection(Server_connection.string_connction))
            {
                sql_conn.Open();
                SqlCommand sql_command = new SqlCommand("AccoutDeleteByNumber", sql_conn);
                sql_command.CommandType = CommandType.StoredProcedure;
                sql_command.Parameters.AddWithValue("@AccNumber", Convert.ToInt32(dataGridViewBankAcc.CurrentRow.Cells["AccNumber"].Value));
                sql_command.ExecuteNonQuery();
            }
        }
    }
}
