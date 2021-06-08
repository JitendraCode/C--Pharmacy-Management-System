using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace finalblackbook
{
    public partial class overall : Form
    {
        public overall()
        {
            InitializeComponent();
        }

        private void salesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet2);

        }

        private void overall_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet2.sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.pharmacyDataSet2.sales);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
