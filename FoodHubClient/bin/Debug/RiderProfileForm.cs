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
    public partial class RiderProfileForm : Form
    {
        public RiderProfileForm()
        {
            InitializeComponent();
        }

        private void RiderProfileForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodhubDataSet7.Rider' table. You can move, or remove it, as needed.
            this.riderTableAdapter.Fill(this.foodhubDataSet7.Rider);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RiderDashboardForm obj = new RiderDashboardForm();
            obj.Show();
            this.Hide();
        }
    }
}
