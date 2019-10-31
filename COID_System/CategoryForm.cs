using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COID_System.dao;
using System.Collections;
using System.Data.SqlClient;
using System.Reflection;

namespace COID_System
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            fillGrip();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void fillGrip()
        {
            var ArrayCategory = DaoCategory.GetCatagory();
            DataTable dt = new DataTable();
           

            try
            {
                dt.TableName = "localVehicleDetails";

                foreach (PropertyInfo property in ArrayCategory[0].GetType().GetProperties())
                {
                    dt.Columns.Add(new DataColumn(property.Name, property.PropertyType));
                }

                foreach (var i in ArrayCategory)
                {
                    DataRow newRow = dt.NewRow();
                    foreach (PropertyInfo property in i.GetType().GetProperties())
                    {
                        newRow[property.Name] = i.GetType().GetProperty(property.Name).GetValue(i, null);
                    }
                    dt.Rows.Add(newRow);
                }

                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string description = textBoxDescription.Text.Trim();
            DaoCategory.InsertCategory(name, description);
            MessageBox.Show("done!");
            fillGrip();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                string name = row.Cells[1].Value.ToString();
                string description = row.Cells[2].Value.ToString();

                DaoCategory.EditCategory(id, name, description);
            }
            MessageBox.Show("done!");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id1 = 110;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                id1 = id;

                DaoCategory.DeleteCategory(id);
            }
            fillGrip();
            MessageBox.Show("done!" + id1);
        }
    }
}