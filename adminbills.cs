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
    public partial class adminbills : Form
    {
        public adminbills()
        {
            InitializeComponent();
        }

        private void payBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.payBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet3); //connecting GridView with database

        }

        private void adminbills_Load(object sender, EventArgs e)
        {
            this.payTableAdapter.Fill(this.pharmacyDataSet3.pay);

        }

        private void payBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
