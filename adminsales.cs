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
    public partial class adminsales : Form
    {
        public adminsales()
        {
            InitializeComponent();
        }

        private void payBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.payBindingSource.EndEdit(); //connecting GridView to Database.
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet3); //Connecting dataset to Grid

        }

        private void adminsales_Load(object sender, EventArgs e)
        {
            this.payTableAdapter.Fill(this.pharmacyDataSet3.pay);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //Back Button
        }
    }
}
