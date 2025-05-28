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
    public partial class ReportGenerationForm : Form
    {
        public ReportGenerationForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SSNOE6V\SQLEXPRESS;Initial Catalog=Foodhub;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm obj = new MainForm();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // 1) Total Deliveries (status = Delivered)
                var cmdTotal = new SqlCommand(
                    "SELECT COUNT(*) FROM Orders WHERE status = 'Delivered'",
                    con);
                textBox3.Text = cmdTotal.ExecuteScalar().ToString();

                // 2) Average Delivery Time (dispatch_time - order_time) in minutes
                var cmdAvg = new SqlCommand(@"
            SELECT 
              AVG(DATEDIFF(MINUTE, order_time, dispatch_time)) 
            FROM Orders 
            WHERE dispatch_time IS NOT NULL",
                    con);
                var avg = cmdAvg.ExecuteScalar();
                textBox4.Text = avg == DBNull.Value
                    ? "N/A"
                    : avg.ToString();

                // 3) Total Revenue (sum of order_amount)
                var cmdRevenue = new SqlCommand(
                    "SELECT SUM(order_amount) FROM Orders",
                    con);
                var rev = cmdRevenue.ExecuteScalar();
                textBox5.Text = rev == DBNull.Value
                    ? "0.00"
                    : ((decimal)rev).ToString("F2");

                // 4) Most Sold Item (highest sum of quantity)
                var cmdPopular = new SqlCommand(@"
            SELECT TOP 1 i.item_name 
            FROM Order_Item oi
            JOIN Item i ON oi.item_no = i.item_no
            GROUP BY i.item_name
            ORDER BY SUM(oi.quantity) DESC",
                    con);
                var popular = cmdPopular.ExecuteScalar();
                textBox6.Text = popular == null
                    ? "N/A"
                    : popular.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
