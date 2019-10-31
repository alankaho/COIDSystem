using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace COID_System
{
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderSystemDataSet2.food' table. You can move, or remove it, as needed.
            this.foodTableAdapter.Fill(this.orderSystemDataSet2.food);
            // TODO: This line of code loads data into the 'orderSystemDataSet1.food' table. You can move, or remove it, as needed.
         

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string description = textBoxDescription.Text;
            double price = double.Parse(textBoxPrice.Text);
            string category = comboBoxCategory.Text;
            MessageBox.Show("done!" + category);
            int categoryId = dao.DaoCategory.GetIdCategory(category);

            dao.DaoFood.InsertFood(name, description, price, categoryId);
            

        }
    }
}
