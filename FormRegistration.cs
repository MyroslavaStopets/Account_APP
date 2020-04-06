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
    public partial class FormRegistration : Form
    {
        User model =  new User();
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e){}

        delegate bool Valid_func_delegate(string s);
        private bool validation(Valid_func_delegate func, string what, string to)
        {
            if (func(to))
            {
                what = to;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            model.Firstname = txtFirstname.Text.Trim();
            model.Lastname = txtLastname.Text.Trim();
            model.Email = txtEmail.Text.Trim();
            model.Pasword = Helpers.Hash(txtPassword.Text.Trim());
            model.Rol = comboBoxRole.Text.Trim();
            using (AccountDBEntities db = new AccountDBEntities())
            {
                    db.User.Add(model);
                    db.SaveChanges();
            }
            MessageBox.Show("Registrated successfully");
            this.Hide();
            FormHome f = new FormHome();
            f.Show();
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            Valid_func_delegate delegate_func = Helpers.Valid_surname_name;
            if (validation(delegate_func, model.Firstname, txtFirstname.Text.Trim()))
            {
                e.Cancel = false;
                errorProviderFirstName.SetError(txtFirstname, "");
            }
            else
            {
                e.Cancel = true;
                errorProviderFirstName.SetError(txtFirstname, "Name should consist only of letters");
            }
        }
        private void textBoxLastName_Validating(object sender, CancelEventArgs e)
        {
            Valid_func_delegate delegate_func = Helpers.Valid_surname_name;
            if (validation(delegate_func, model.Lastname, txtLastname.Text.Trim()))
            {
                e.Cancel = false;
                errorProviderLastName.SetError(txtLastname, "");
            }
            else
            {
                e.Cancel = true;
                errorProviderLastName.SetError(txtLastname, "Last name should consist only of letters");
            }
        }
        public void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            string mySQL = string.Empty;
            mySQL += "SELECT  * FROM [AccountDB].[dbo].[User] WHERE[AccountDB].[dbo].[User].Email = '" +txtEmail.Text.Trim() + "'";
            DataTable userData = Server_connection.executeSQL(mySQL);
            if (userData.Rows.Count > 0)
            {
                e.Cancel = true;
                errorProviderEmail.SetError(txtEmail, "User with this email already exists ");
            }
            Valid_func_delegate delegate_func = Helpers.Valid_email;
            if (validation(delegate_func, model.Email, txtEmail.Text.Trim()))
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
            Valid_func_delegate delegate_func = Helpers.Valid_password;
            if (validation(delegate_func, model.Pasword, txtPassword.Text.Trim()))
            {
                if (txtPassword.Text.Trim() == txtConfirmPassword.Text.Trim())
                {
                    e.Cancel = false;
                    errorProviderPassword.SetError(txtPassword, "");
                }
                else
                {
                    e.Cancel = true;
                    errorProviderPassword.SetError(txtPassword, "Two passwords does not matches");
                }
            }
            else
            {
                e.Cancel = true;
                errorProviderPassword.SetError(txtPassword, "Password should consist of more than 8 symbols(Upper letter, lower letter, number, special symbol  )");
            }
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void label7_Click(object sender, EventArgs e){}
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void checkBoxCofirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCofirmPassword.Checked == true)
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
