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
    public partial class OrderEntryForm : Form
    {
        public OrderEntryForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SSNOE6V\SQLEXPRESS;Initial Catalog=Foodhub;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            StaffForm obj = new StaffForm();
            obj.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderEntryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodhubDataSet3.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter1.Fill(this.foodhubDataSet3.Item);
            // TODO: This line of code loads data into the 'foodhubDataSet2.Order_Item' table. You can move, or remove it, as needed.
            this.order_ItemTableAdapter.Fill(this.foodhubDataSet2.Order_Item);
            // TODO: This line of code loads data into the 'foodhubDataSet1.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.foodhubDataSet1.Item);
            // TODO: This line of code loads data into the 'foodhubDataSet1.Ingredient' table. You can move, or remove it, as needed.
            this.ingredientTableAdapter.Fill(this.foodhubDataSet1.Ingredient);

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCustomer.Clear();
            txtOrderNo.Clear();
            textBox1.Clear();
            txtLocationId.Clear();
            txtAmount.Clear();
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = false;
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void btnIngredient_Click(object sender, EventArgs e)
        {
            IngredientsForm obj = new IngredientsForm();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int custId = int.Parse(txtCustomer.Text);
                int empNo = int.Parse(textBox1.Text);
                DateTime oDate = dateTimePicker1.Value;
                TimeSpan oTime = dateTimePicker2.Value.TimeOfDay;
                int locId = int.Parse(txtLocationId.Text);

                // Determine payment method from three radio buttons
                string pay;
                if (radioButton1.Checked)
                    pay = "Cash";
                else if (radioButton2.Checked)
                    pay = "Credit Card";
                else
                    pay = "Online Payment";

                string st = comboBox1.Text;
                decimal total = decimal.Parse(txtAmount.Text);
                TimeSpan disp = DateTime.Now.TimeOfDay;

                string sql = "INSERT INTO Orders (" +
                             "customer_id, employee_no, order_date, order_time, " +
                             "order_amount, payment_method, status, location_id, dispatch_time" +
                             ") VALUES (" +
                             custId + "," +
                             empNo + ",'" +
                             oDate.ToString("yyyy-MM-dd") + "','" +
                             oTime + "'," +
                             total + ",'" +
                             pay + "','" +
                             st + "'," +
                             locId + ",'" +
                             disp + "')";

                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order submitted");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please make sure all numeric fields are valid numbers.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrderHistoryForm obj = new OrderHistoryForm();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculatorForm obj = new CalculatorForm();
            obj.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int orderNo = int.Parse(txtOrderNo.Text);

                string sql = "SELECT * FROM Orders WHERE order_no = " + orderNo;
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        // Assuming these are your control names:
                        txtCustomer.Text = rd.GetInt32(rd.GetOrdinal("customer_id")).ToString();
                        textBox1.Text = rd.GetInt32(rd.GetOrdinal("employee_no")).ToString();
                        dateTimePicker1.Value = rd.GetDateTime(rd.GetOrdinal("order_date"));
                        dateTimePicker2.Value = DateTime.Today + rd.GetTimeSpan(rd.GetOrdinal("order_time"));
                        txtAmount.Text = rd.GetDecimal(rd.GetOrdinal("order_amount")).ToString();

                        string pm = rd.GetString(rd.GetOrdinal("payment_method"));
                        radioButton1.Checked = (pm == "Cash");
                        radioButton2.Checked = (pm == "Credit Card");
                        radioButton3.Checked = (pm == "Online Payment");

                        comboBox1.Text = rd.GetString(rd.GetOrdinal("status"));
                        txtLocationId.Text = rd.GetInt32(rd.GetOrdinal("location_id")).ToString();

                        var disp = rd.IsDBNull(rd.GetOrdinal("dispatch_time"))
                                   ? TimeSpan.Zero
                                   : rd.GetTimeSpan(rd.GetOrdinal("dispatch_time"));
                        dateTimePicker3.Value = DateTime.Today + disp;
                    }
                    else
                    {
                        MessageBox.Show("Order not found.");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Order Number must be a valid integer.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int orderNo = int.Parse(txtOrderNo.Text);
                string sql = "DELETE FROM Orders WHERE order_no = " + orderNo;
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                int affected = cmd.ExecuteNonQuery();
                if (affected > 0)
                {
                    MessageBox.Show("Order #" + orderNo + " deleted.");
                }
                else
                {
                    MessageBox.Show("No order found with that number.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Order Number must be numeric.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ItemEntryForm obj = new ItemEntryForm();
            obj.Show();
            this.Hide();
        }
    }
}
