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
    public partial class ComboForm : Form
    {
        public ComboForm()
        {
            InitializeComponent();
        }

        private void ComboForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderSystemDataSet.combo' table. You can move, or remove it, as needed.
            this.comboTableAdapter.Fill(this.orderSystemDataSet.combo);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
