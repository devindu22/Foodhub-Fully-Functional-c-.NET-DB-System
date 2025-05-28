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
    public partial class OrderStatusUpdateForm : Form
    {
        public OrderStatusUpdateForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SSNOE6V\SQLEXPRESS;Initial Catalog=Foodhub;Integrated Security=True");

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOrderNo.Text))
                {
                    MessageBox.Show("Please enter an Order No.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int orderNo = int.Parse(txtOrderNo.Text);
                string status = comboBox1.Text;
                if (string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("Please select an Order Status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = "UPDATE Orders SET status = '" + status + "' WHERE order_no = " + orderNo;
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order status updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOrderNo.Clear();
                    comboBox1.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No order found with Order No: " + orderNo, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please make sure the Order No is a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RiderDeliverySummaryForm obj = new RiderDeliverySummaryForm();
            obj.Show();
            this.Hide();
        }
    }
}
