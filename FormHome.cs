using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Account_App
{
    public partial class FormHome : Form
    {
        public FormHome(string splash)
        {
            if (splash == "yes")
            {
                Thread t = new Thread(new ThreadStart(StartForm));
                t.Start();
                Thread.Sleep(7000);
                InitializeComponent();
                t.Abort();
            }
        }
        public FormHome()
        {
            InitializeComponent();
        }
        public void StartForm()
        {
            Application.Run(new FormSplashScreen());
        }
        private void FormHome_Load(object sender, EventArgs e){}

        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistration f = new FormRegistration();
            f.Show();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f = new FormLogin();
            f.Show();
        }
    }
}
