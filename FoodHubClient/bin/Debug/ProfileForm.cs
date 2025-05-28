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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SSNOE6V\SQLEXPRESS;Initial Catalog=Foodhub;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerDashboardForm obj = new CustomerDashboardForm();
            obj.Show();
            this.Hide();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            try
            {
                int customerId = 1;

                string customerQuery = "SELECT * FROM Customer WHERE customer_id = " + customerId;
                SqlCommand customerCmd = new SqlCommand(customerQuery, con);
                con.Open();
                SqlDataAdapter customerDa = new SqlDataAdapter(customerCmd);
                DataTable customerDt = new DataTable();
                customerDa.Fill(customerDt);
                con.Close();

                if (customerDt.Rows.Count == 0)
                {
                    MessageBox.Show("No customer found with Customer ID: " + customerId, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                dataGridView1.DataSource = customerDt;

                string locationQuery = "SELECT * FROM Location WHERE customer_id = " + customerId;
                SqlCommand locationCmd = new SqlCommand(locationQuery, con);
                con.Open();
                SqlDataAdapter locationDa = new SqlDataAdapter(locationCmd);
                DataTable locationDt = new DataTable();
                locationDa.Fill(locationDt);
                con.Close();

                if (locationDt.Rows.Count == 0)
                {
                    MessageBox.Show("No locations found for Customer ID: " + customerId, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dataGridView3.DataSource = locationDt;

                string orderQuery = "SELECT * FROM Orders WHERE customer_id = " + customerId;
                SqlCommand orderCmd = new SqlCommand(orderQuery, con);
                con.Open();
                SqlDataAdapter orderDa = new SqlDataAdapter(orderCmd);
                DataTable orderDt = new DataTable();
                orderDa.Fill(orderDt);
                con.Close();

                if (orderDt.Rows.Count == 0)
                {
                    MessageBox.Show("No order history found for Customer ID: " + customerId, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dataGridView2.DataSource = orderDt;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
