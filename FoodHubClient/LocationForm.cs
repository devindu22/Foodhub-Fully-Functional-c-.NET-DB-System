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
    public partial class LocationForm : Form
    {
        public LocationForm()
        {
            InitializeComponent();
        }

        private void LocationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodhubDataSet11.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.foodhubDataSet11.Location);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RiderDeliverySummaryForm obj = new RiderDeliverySummaryForm();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeleForm obj = new TeleForm();
            obj.Show();
            this.Hide();
        }
    }
}
