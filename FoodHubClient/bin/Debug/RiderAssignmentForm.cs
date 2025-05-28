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
    public partial class RiderAssignmentForm : Form
    {
        public RiderAssignmentForm()
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

        private void RiderAssignmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodhubDataSet5.Assign' table. You can move, or remove it, as needed.
            this.assignTableAdapter.Fill(this.foodhubDataSet5.Assign);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string employee_no = textBox2.Text;
                string registration_no = textBox3.Text;
                string assign_date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string m_reader_at_assign = textBox4.Text;
                string m_reader_at_return = textBox5.Text;

                string insert = "INSERT INTO Assign VALUES('" + employee_no + "', '" + registration_no + "', '" + assign_date + "', '" + m_reader_at_assign + "', '" + m_reader_at_return + "')";
                SqlCommand cmd = new SqlCommand(insert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Assigned Successfully");
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
            try
            {
                string employee_no = textBox2.Text;
                string registration_no = textBox3.Text;
                string assign_date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string m_reader_at_assign = textBox4.Text;
                string m_reader_at_return = textBox5.Text;

                string update = "UPDATE Assign SET registration_no = '" + registration_no + "', assign_no = '" + assign_date + "', m_reader_at_assign = '" + m_reader_at_assign + "', m_reader_at_return = '" + m_reader_at_return + "' WHERE employee_no = '"+ employee_no +"'";
                SqlCommand cmd = new SqlCommand(update, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
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
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Today;
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MotorbikeForm obj = new MotorbikeForm();
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string employee_no = textBox2.Text;
                string select = "SELECT * FROM Assign WHERE employee_no = '" + employee_no + "'";
                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string employee_no = textBox2.Text;
                string delete = "DELETE FROM Assign WHERE employee_no = '" + employee_no + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
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

        private void button7_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM Assign";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RiderProfileForm obj = new RiderProfileForm();
            obj.Show();
            this.Hide();
        }
    }
}
