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
    public partial class FormAccSettings : Form
    {
        private string user_id;
        User model = new User();
        public FormAccSettings(string user_id)
        {
            this.user_id = user_id;
            InitializeComponent();
        }

        void Clear()
        {
            txtFirstname.Text = txtLastname.Text = txtEmail.Text = comboBoxRole.Text = "";
            btnSave.Text = "Save";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void FormAccSettings_Load(object sender, EventArgs e)
        {
            string mySQL = string.Empty;
            mySQL += "SELECT * FROM [AccountDB].[dbo].[User] ";
            mySQL += "WHERE UserID = " + user_id;
            DataTable userData = Server_connection.executeSQL(mySQL);
            txtFirstname.Text = userData.Rows[0][1].ToString();
            txtLastname.Text = userData.Rows[0][2].ToString();
            txtEmail.Text = userData.Rows[0][3].ToString();
            comboBoxRole.Text = userData.Rows[0][5].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string mySQL = string.Empty;
            mySQL += "UPDATE[AccountDB].[dbo].[User] SET Firstname = '" + txtFirstname.Text.Trim() + "', Lastname  = '" +
                txtLastname.Text.Trim() + "' , Email  = '" + txtEmail.Text.Trim() + "', Rol = '" + comboBoxRole.Text + "' WHERE UserID = " + this.user_id;
            DataTable userData = Server_connection.executeSQL(mySQL);
            MessageBox.Show("Updated successfuly");
            mySQL = string.Empty;
            mySQL += "SELECT * FROM [AccountDB].[dbo].[User] ";
            mySQL += "WHERE Email = '" + txtEmail.Text.Trim() + "'";
            userData = Server_connection.executeSQL(mySQL);
            this.Hide();
            FormBankAccounts fba = new FormBankAccounts(userData.Rows[0][0].ToString());
            fba.ShowDialog();
            //FormHome fh = new FormHome();
            //fh.Show();
        }
    }
}
