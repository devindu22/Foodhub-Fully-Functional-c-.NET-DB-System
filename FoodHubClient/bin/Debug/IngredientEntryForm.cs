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
    public partial class IngredientEntryForm : Form
    {
        public IngredientEntryForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SSNOE6V\SQLEXPRESS;Initial Catalog=Foodhub;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            IngredientsForm obj = new IngredientsForm();
            obj.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int itemNo = int.Parse(txtItemNo.Text);
                string ingredient = txtIngredient.Text.Trim();

                string sql = "INSERT INTO Ingredient (item_no, ingredient) VALUES (" + itemNo + ", '" + ingredient + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ingredient saved successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                int itemNo = int.Parse(txtItemNo.Text);
                string newIngredient = txtIngredient.Text.Trim();

                string sql = "UPDATE Ingredient SET ingredient = '" + newIngredient + "' WHERE item_no = " + itemNo + " AND ingredient = '" + newIngredient + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ingredient updated successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int itemNo = int.Parse(txtItemNo.Text);
                string ingredient = txtIngredient.Text.Trim();

                string sql = "DELETE FROM Ingredient WHERE item_no = " + itemNo + " AND ingredient = '" + ingredient + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ingredient deleted successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtIngredient.Clear();

        }
    }
}
