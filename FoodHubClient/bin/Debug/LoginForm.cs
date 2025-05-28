using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace FoodHubClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;


            if (username.Equals("admin", StringComparison.OrdinalIgnoreCase)
                && password == "123")
            {
                MessageBox.Show("Welcome, Administrator!", "Login Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                var frm = new MainForm();
                frm.Show();
                this.Hide();
            }
            else if (username.Equals("customer", StringComparison.OrdinalIgnoreCase)
                     && password == "456")
            {
                MessageBox.Show("Welcome back, Enjoy Ordering!", "Login Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                var frm = new CustomerDashboardForm();
                frm.Show();
                this.Hide();
            }
            else if (username.Equals("rider", StringComparison.OrdinalIgnoreCase)
                     && password == "789")
            {
                var frm = new RiderDashboardForm();
                frm.Show();
                this.Hide();
            }
            else if (username.Equals("staff", StringComparison.OrdinalIgnoreCase)
                     && password == "111")
            {
                var frm = new StaffForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }

    public enum UserRole
    {
        Administrator,
        Customer,
        Rider,
        Staff
    }
}
