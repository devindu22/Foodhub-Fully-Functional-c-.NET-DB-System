using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHubClient
{
    public partial class IngredientsForm : Form
    {
        public IngredientsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderEntryForm obj = new OrderEntryForm();
            obj.Show();
            this.Hide();
        }

        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodhubDataSet10.Ingredient' table. You can move, or remove it, as needed.
            this.ingredientTableAdapter.Fill(this.foodhubDataSet10.Ingredient);

        }
    }
}
