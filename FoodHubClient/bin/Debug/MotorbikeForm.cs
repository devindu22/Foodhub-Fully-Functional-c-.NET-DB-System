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
    public partial class MotorbikeForm : Form
    {
        public MotorbikeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RiderAssignmentForm obj = new RiderAssignmentForm();
            obj.Show();
            this.Hide();
        }

        private void MotorbikeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodhubDataSet18.Motorbike' table. You can move, or remove it, as needed.
            this.motorbikeTableAdapter.Fill(this.foodhubDataSet18.Motorbike);

        }
    }
}
