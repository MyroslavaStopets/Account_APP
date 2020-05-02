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
    public partial class FormUsersList : Form
    {
        private string user_id;
        public FormUsersList(string user_id)
        {
            this.user_id = user_id;
            InitializeComponent();
        }

        private void FormUsersList_Load(object sender, EventArgs e)
        {
            string mySQL = string.Empty;
            mySQL += "SELECT  [AccountDB].[dbo].[User].UserID, [AccountDB].[dbo].[User].Firstname," +
                " [AccountDB].[dbo].[User].Lastname, [AccountDB].[dbo].[User].Email, [AccountDB].[dbo].[User].Rol," +
                " [AccountDB].[dbo].[User].STAT FROM[AccountDB].[dbo].[User] WHERE[AccountDB].[dbo].[User].UserID !=";
            mySQL += user_id;
            DataTable userData = Server_connection.executeSQL(mySQL);
            if (userData.Rows.Count > 0)
            {
                dataGridViewUsers.DataSource = userData;
            }
            else
            {
                MessageBox.Show("There is no users");
            }
        }

        private void linkAccSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormAccSettings fas = new FormAccSettings(user_id);
            fas.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome fh = new FormHome();
            fh.Show();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mySQL = string.Empty;
            if (dataGridViewUsers.CurrentCell.ColumnIndex == 5)
            {
                mySQL += "UPDATE [AccountDB].[dbo].[User] SET STAT = '";
                if ((String)dataGridViewUsers[5, dataGridViewUsers.CurrentCell.RowIndex].Value == "Active")
                {
                    mySQL += "Inactive' WHERE UserID = ";
                    dataGridViewUsers.CurrentCell.Value = "Inactive";
                }
                else 
                {
                    mySQL += "Active' WHERE UserID = ";
                    dataGridViewUsers.CurrentCell.Value = "Active";
                }
                mySQL += dataGridViewUsers[0, dataGridViewUsers.CurrentCell.RowIndex].Value;
                DataTable userData = Server_connection.executeSQL(mySQL);
            }
            else
            {
                mySQL += "SELECT[AccountDB].[dbo].[Accounts].AccNumber, [AccountDB].[dbo].[Accounts].Firstname,[AccountDB].[dbo].[Accounts].Lastname,[AccountDB].[dbo].[Accounts].Summ, " +
               " [AccountDB].[dbo].[Accounts].Last_year FROM[AccountDB].[dbo].[Accounts] INNER JOIN[AccountDB].[dbo].[Usesr_Accounts]" +
               " ON[AccountDB].[dbo].[Accounts].AccNumber = [AccountDB].[dbo].[Usesr_Accounts].AccNumber WHERE[AccountDB].[dbo].[Usesr_Accounts].UserID = ";
                mySQL += dataGridViewUsers[0, dataGridViewUsers.CurrentCell.RowIndex].Value;
                DataTable userData = Server_connection.executeSQL(mySQL);
                if (userData.Rows.Count > 0)
                {
                    if ((String)dataGridViewUsers[4, dataGridViewUsers.CurrentCell.RowIndex].Value == "Client")
                    {
                        FormAccountList fal = new FormAccountList(dataGridViewUsers[0, dataGridViewUsers.CurrentCell.RowIndex].Value.ToString());
                        fal.ShowDialog();
                    }
                    if ((String)dataGridViewUsers[4, dataGridViewUsers.CurrentCell.RowIndex].Value == "Bank")
                    {
                        FormBankAccounts fba = new FormBankAccounts(dataGridViewUsers[0, dataGridViewUsers.CurrentCell.RowIndex].Value.ToString());
                        fba.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("This user doesn't have any account");
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistration fr = new FormRegistration("admin", user_id);
            fr.Show();
        }
    }
}
