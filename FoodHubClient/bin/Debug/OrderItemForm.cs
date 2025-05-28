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
    public partial class OrderItemForm : Form
    {
        public OrderItemForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderHistoryForm obj = new OrderHistoryForm();
            obj.Show();
            this.Hide();
        }

        private void OrderItemForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodhubDataSet19.Order_Item' table. You can move, or remove it, as needed.
            this.order_ItemTableAdapter.Fill(this.foodhubDataSet19.Order_Item);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuItemEntryForm obj = new MenuItemEntryForm();
            obj.Show();
            this.Hide();
        }
    }
}
