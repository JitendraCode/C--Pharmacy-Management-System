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
    public partial class admincheckstocks : Form
    {
        public admincheckstocks()
        {
            InitializeComponent();
        }

        private void mediBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mediBindingSource.EndEdit(); //connecting dataset to database
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet1);

        }

        private void admincheckstocks_Load(object sender, EventArgs e)
        {
            this.mediTableAdapter.Fill(this.pharmacyDataSet1.Medi); //connecting dataset to database

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //back button
        }
    }
}
