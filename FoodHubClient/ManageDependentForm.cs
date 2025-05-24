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
    public partial class ManageDependentForm : Form
    {
        public ManageDependentForm()
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

        private void ManageDependentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodhubDataSet.Dependent' table. You can move, or remove it, as needed.
            this.dependentTableAdapter.Fill(this.foodhubDataSet.Dependent);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string view = "SELECT * FROM Dependent";
                SqlDataAdapter da = new SqlDataAdapter(view, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int employee_no = int.Parse(textBox1.Text);
                string search = "SELECT * FROM Dependent WHERE employee_no = " + employee_no + "";
                SqlCommand cmd = new SqlCommand(search, con);
                SqlDataReader rd;
                con.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    textBox2.Text = rd[1].ToString();
                    textBox3.Text = rd[2].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(rd[3]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int employee_no = int.Parse(textBox1.Text);
                string delete = "DELETE FROM Dependent WHERE employee_no = " + employee_no + "";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Removed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
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
                int employee_no = int.Parse(textBox1.Text);
                string dependent_name = textBox2.Text;
                string relationship = textBox3.Text;
                string dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                string update = "UPDATE Dependent SET dependent_name = '" + dependent_name + "', '" + relationship + "', '" + dob + "' WHERE employee_no = "+ employee_no +"";
                SqlCommand cmd = new SqlCommand(update, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int employee_no = int.Parse(textBox1.Text);
                string dependent_name = textBox2.Text;
                string relationship = textBox3.Text;
                string dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                string insert = "INSERT INTO Dependent values(" + employee_no + ", '" + dependent_name + "', '" + relationship + "', '" + dob + "' )";
                SqlCommand cmd = new SqlCommand(insert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
