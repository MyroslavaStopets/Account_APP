using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_App
{
    public partial class FormAccountList : Form
    {
        private string user_id;
        public FormAccountList(string user_id)
        {
            this.user_id = user_id;
            InitializeComponent();
        }

        private void FormAccountList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void FormAccountList_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you realy want to exit?", "Program closing",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void FormAccountList_Load(object sender, EventArgs e)
        {
            string mySQL = string.Empty;
            mySQL += "SELECT  [AccountDB].[dbo].[Accounts].AccNumber, [AccountDB].[dbo].[Accounts].Firstname,[AccountDB].[dbo].[Accounts].Lastname, " +
                " [AccountDB].[dbo].[Accounts].Last_year, FORMAT([AccountDB].[dbo].[Accounts].Summ, 'C', 'de-de') AS \"Sum on account\" FROM[AccountDB].[dbo].[Accounts] INNER JOIN[AccountDB].[dbo].[Usesr_Accounts]" +
                " ON[AccountDB].[dbo].[Accounts].AccNumber = [AccountDB].[dbo].[Usesr_Accounts].AccNumber WHERE[AccountDB].[dbo].[Usesr_Accounts].UserID = ";
            mySQL += user_id;
            DataTable userData = Server_connection.executeSQL(mySQL);
            if (userData.Rows.Count > 0)
            {
                dataGridViewAccounts.DataSource = userData;
            }
            else
            {
                MessageBox.Show("This user does not have an account");
            }
        }
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
                dataGridViewAccounts.DataSource = userData;
            }
            else
            {
                MessageBox.Show("You should chooce by what value to sort");
            }
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
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
                    dataGridViewAccounts.DataSource = userData;
                }
                else
                {
                    MessageBox.Show("No matches finded");
                }
        }

        private void linkAccSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormAccSettings fas = new FormAccSettings();
            fas.ShowDialog();
        }
    }
}
