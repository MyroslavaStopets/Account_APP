using Npgsql;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string mySQL = string.Empty;
            mySQL += "SELECT * FROM [AccountDB].[dbo].[User] ";
            mySQL += "WHERE Email = '" + txtEmail.Text.Trim() + "'";
            DataTable userData = Server_connection.executeSQL(mySQL);
            if (userData.Rows.Count == 1)
            {
                string hashed_pass = userData.Rows[0][4].ToString();
                if (Helpers.Verify(txtPassword.Text.Trim(), hashed_pass))
                {
                    txtEmail.Clear();
                    txtPassword.Clear();
                    PasswordCheckBox.Checked = false;
                    if (userData.Rows[0][6].ToString() == "Inactive")
                    {
                        MessageBox.Show("This user is bloked by administartor");
                    }
                    else
                    {
                        if (userData.Rows[0][5].ToString() == "Client")
                        {
                            this.Hide();
                            FormAccountList fal = new FormAccountList(userData.Rows[0][0].ToString());
                            fal.ShowDialog();
                        }
                        if (userData.Rows[0][5].ToString() == "Admin")
                        {
                            this.Hide();
                            FormUsersList ul = new FormUsersList(userData.Rows[0][0].ToString());
                            ul.ShowDialog();
                        }
                        if (userData.Rows[0][5].ToString() == "Bank")
                        {
                            this.Hide();
                            FormBankAccounts fba = new FormBankAccounts(userData.Rows[0][0].ToString());
                            fba.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong password");
                }
            }
            else 
            {
                MessageBox.Show("User with this email and password is not registreted");
            }
        }
        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (Helpers.Valid_email(txtEmail.Text.Trim()))
            {
                e.Cancel = false;
                errorProviderEmail.SetError(txtEmail, "");
            }
            else
            {
                e.Cancel = true;
                errorProviderEmail.SetError(txtEmail, "Email should match to template text@text.text ");
            }
        }
        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (Helpers.Valid_password(txtPassword.Text.Trim()))
            {
                e.Cancel = false;
                errorProviderPassword.SetError(txtPassword, "");
            }
            else
            {
                e.Cancel = true;
                errorProviderPassword.SetError(txtPassword, "Password should consist of more than 8 symbols(Upper letter, lower letter, number, special symbol  )");
            }
        }
        private void FormLogin_Load(object sender, EventArgs e){}
        private void PasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordCheckBox.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
