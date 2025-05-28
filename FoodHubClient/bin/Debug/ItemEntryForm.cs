using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FoodHubClient
{
    public partial class ItemEntryForm : Form
    {
        public ItemEntryForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SSNOE6V\SQLEXPRESS;Initial Catalog=Foodhub;Integrated Security=True");

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderEntryForm obj = new OrderEntryForm();
            obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OrderItemForm obj = new OrderItemForm();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int orderNo = int.Parse(txtOrderNo.Text);
                int itemNo = int.Parse(txtItemNo.Text);
                int qty = int.Parse(txtQuantity.Text);
                decimal price = decimal.Parse(txtUnitPrice.Text);

                string sql = "INSERT INTO Order_Item VALUES(" + orderNo + "," + itemNo + "," + qty + "," + price + ")";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int orderNo = int.Parse(txtOrderNo.Text);
                int itemNo = int.Parse(txtItemNo.Text);
                int qty = int.Parse(txtQuantity.Text);
                decimal price = decimal.Parse(txtUnitPrice.Text);

                string sql = "UPDATE Order_Item SET " + "quantity=" + qty + ", " + "unit_price=" + price +  " WHERE order_no=" + orderNo + "  AND item_no=" + itemNo;
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int orderNo = int.Parse(txtOrderNo.Text);
                int itemNo = int.Parse(txtItemNo.Text);

                string sql = "DELETE FROM Order_Item " + "WHERE order_no=" + orderNo + " AND item_no=" + itemNo;
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtOrderNo.Clear();
            txtItemNo.Clear();
            txtQuantity.Clear();
            txtUnitPrice.Clear();
            txtOrderNo.Focus();
        }
    }
}
