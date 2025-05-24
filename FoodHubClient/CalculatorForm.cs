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
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int ans = n1 + n2;
            textBox3.Text = ans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int ans = n1 - n2;
            textBox3.Text = ans.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int ans = n1 * n2;
            textBox3.Text = ans.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            float ans = n1 / n2;
            textBox3.Text = ans.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrderEntryForm obj = new OrderEntryForm();
            obj.Show();
            this.Hide();
        }
    }
}
