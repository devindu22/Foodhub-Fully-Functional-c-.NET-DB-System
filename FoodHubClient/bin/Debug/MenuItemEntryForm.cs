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
    public partial class MenuItemEntryForm : Form
    {
        public MenuItemEntryForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SSNOE6V\SQLEXPRESS;Initial Catalog=Foodhub;Integrated Security=True");

        private void MenuItemEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderItemForm obj = new OrderItemForm();
            obj.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = txtItemName.Text.Trim();
                string category = txtCategory.Text.Trim();
                decimal price = decimal.Parse(txtPrice.Text);

                string sql = "INSERT INTO Item (item_name, category, price) VALUES ('" + itemName + "', '" + category + "', " + price + ")";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item saved successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please make sure the Price is a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int itemNo = int.Parse(txtItemNo.Text);
                string itemName = txtItemName.Text.Trim();
                string category = txtCategory.Text.Trim();
                decimal price = decimal.Parse(txtPrice.Text);

                string checkQuery = "SELECT COUNT(*) FROM Item WHERE item_no = " + itemNo;
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                con.Open();
                int rowCount = (int)checkCmd.ExecuteScalar();
                con.Close();

                if (rowCount == 0)
                {
                    MessageBox.Show("No item found with Item No: " + itemNo, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string sql = "UPDATE Item SET item_name = '" + itemName + "', category = '" + category + "', price = " + price + " WHERE item_no = " + itemNo;
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item updated successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (FormatException)
            {
                MessageBox.Show("Please make sure Item No and Price are valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

            int itemNo = int.Parse(txtItemNo.Text);

            string checkQuery = "SELECT COUNT(*) FROM Item WHERE item_no = " + itemNo;
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            con.Open();
            int rowCount = (int)checkCmd.ExecuteScalar();
            con.Close();

            string sql = "DELETE FROM Item WHERE item_no = " + itemNo;
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Item deleted successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (FormatException)
            {
            MessageBox.Show("Please make sure Item No is a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemNo.Clear();
            txtItemName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }
    }
}
