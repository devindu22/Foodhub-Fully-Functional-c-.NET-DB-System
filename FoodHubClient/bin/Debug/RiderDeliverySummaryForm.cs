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
    public partial class RiderDeliverySummaryForm : Form
    {
        public RiderDeliverySummaryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RiderDashboardForm obj = new RiderDashboardForm();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderStatusUpdateForm obj = new OrderStatusUpdateForm();
            obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LocationForm obj = new LocationForm();
            obj.Show();
            this.Hide();
        }

        private void RiderDeliverySummaryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodhubDataSet12.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.foodhubDataSet12.Orders);

        }
    }
}
