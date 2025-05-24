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
    public partial class ManageCustomersForm : Form
    {
        public ManageCustomersForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SSNOE6V\SQLEXPRESS;Initial Catalog=Foodhub;Integrated Security=True");
        

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerId.Clear();
            txtName.Clear();
            txtContact.Clear();
            txtNIC.Clear();
            dtpDOB.Value = DateTime.Today.AddYears(-18);

            txtLocationNo.Clear();
            textBox2.Clear();
            txtLane.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            txtCustomerId.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int customer_id = int.Parse(txtCustomerId.Text);
                string customer_name = txtName.Text;
                string nic = txtNIC.Text;
                string contact_no = txtContact.Text;
                string dob = dtpDOB.Value.ToString("yyyy-MM-dd");

                string insert = "INSERT INTO Customer values(" + customer_id + ", '" + customer_name + "','" + contact_no + "', '" + nic + "', '" + dob + "')";
                SqlCommand cmd = new SqlCommand(insert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm obj = new MainForm();
            obj.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtCustomerId.Text;
                string query = "SELECT * FROM Customer WHERE customer_id LIKE '%" + searchTerm + "%'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int customer_id = int.Parse(txtCustomerId.Text);
                string customer_name = txtName.Text;
                string nic = txtNIC.Text;
                string contact_no = txtContact.Text;
                string dob = dtpDOB.Value.ToString("yyyy-MM-dd");

                string update = "UPDATE Customer SET customer_name = '" + customer_name + "', contact_no = '" + contact_no + "', nic = '" + nic + "', dob = '" + dob + "' WHERE customer_id = " + customer_id;
                SqlCommand cmd = new SqlCommand(update, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
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
                
                int customer_id = int.Parse(txtCustomerId.Text);

                string delete = "DELETE FROM Customer WHERE customer_id = " + customer_id;
                SqlCommand cmd = new SqlCommand(delete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            try
            {
                string query1 = "SELECT * FROM Customer";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                con.Open();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;

                string query2 = "SELECT * FROM Location";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView2.DataSource = dt2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ManageCustomersForm_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView2.SelectedRows[0];
                    textBox2.Text = row.Cells["customer_id"].Value.ToString();
                    txtLocationNo.Text = row.Cells["location_no"].Value.ToString();
                    txtLane.Text = row.Cells["lane"].Value.ToString();
                    txtStreet.Text = row.Cells["street"].Value.ToString();
                    txtCity.Text = row.Cells["city"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Please select a row to view", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int customer_id = int.Parse(textBox2.Text);
                string location_no = txtLocationNo.Text;
                string lane = txtLane.Text;
                string street = txtStreet.Text;
                string city = txtCity.Text;

                string insert = "INSERT INTO Location (customer_id, location_no, lane, street, city) values(" + customer_id + ", '" + location_no + "','" + lane + "', '" + street + "', '" + city + "')";
                SqlCommand cmd = new SqlCommand(insert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    txtCustomerId.Text = row.Cells["customer_id"].Value.ToString();
                    txtName.Text = row.Cells["customer_name"].Value.ToString();
                    txtContact.Text = row.Cells["contact_no"].Value.ToString();
                    txtNIC.Text = row.Cells["nic"].Value.ToString();
                    dtpDOB.Value = Convert.ToDateTime(row.Cells["dob"].Value);
                }
                else
                {
                    MessageBox.Show("Please select a row to view", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView2.SelectedRows[0];
                    int customer_id = int.Parse(textBox2.Text);
                    int location_id = Convert.ToInt32(row.Cells["location_id"].Value);
                    string location_no = txtLocationNo.Text;
                    string lane = txtLane.Text;
                    string street = txtStreet.Text;
                    string city = txtCity.Text;

                    string update = "UPDATE Location SET customer_id = " + customer_id + ", location_no = '" + location_no + "', lane = '" + lane + "', street = '" + street + "', city = '" + city + "' WHERE location_id = " + location_id;
                    SqlCommand cmd = new SqlCommand(update, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a row to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = textBox2.Text;
                string query = "SELECT * FROM Location WHERE customer_id LIKE '%" + searchTerm + "%'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
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
                string locationNo = txtLocationNo.Text.Trim();

                string checkQuery = "SELECT COUNT(*) FROM Location WHERE location_no = '" + locationNo + "'";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                con.Open();
                int rowCount = (int)checkCmd.ExecuteScalar();
                con.Close();

                DialogResult result = MessageBox.Show("Are you sure you want to delete location(s) with Location No: " + locationNo + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                string delete = "DELETE FROM Location WHERE location_no = @location_no";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.Parameters.AddWithValue("@location_no", locationNo);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show(rowsAffected + " row(s) deleted successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtLocationNo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
