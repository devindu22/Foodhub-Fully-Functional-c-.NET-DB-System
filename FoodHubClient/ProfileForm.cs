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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerDashboardForm obj = new CustomerDashboardForm();
            obj.Show();
            this.Hide();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
}
