using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHubClient
{
    public partial class CustomerDashboardForm : Form
    {
        public CustomerDashboardForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm obj = new LoginForm();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TeleForm obj = new TeleForm();
            obj.Show();
            this.Hide();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            ProfileForm obj = new ProfileForm();
            obj.Show();
            this.Hide();
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            ProfileForm obj = new ProfileForm();
            obj.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm obj = new MenuForm();
            obj.Show();
            this.Hide();
        }
    }
}
