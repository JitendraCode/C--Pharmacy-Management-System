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
    public partial class adminhome : Form
    {
        public adminhome()
        {
            InitializeComponent();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminsales asales = new adminsales(); //redirecting to another page.
            asales.ShowDialog();
        }

        private void checkStocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admincheckstocks admincheck = new admincheckstocks(); //redirecting to another page.
            admincheck.ShowDialog();
        }

        private void usersOfOrganizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usersoforg users = new usersoforg(); //redirecting to another page.
            users.ShowDialog();
        }

        private void lowestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lowestreport loreport = new lowestreport(); //redirecting to another page.
            loreport.ShowDialog();
        }

        private void highestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            highestreport hireport = new highestreport(); //redirecting to another page.
            hireport.ShowDialog();
        }

        private void overallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            overall ovoreport = new overall(); //redirecting to another page.
            ovoreport.ShowDialog();
        }

        private void lowestProfitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lowest loprofit = new lowest(); //redirecting to another page.
            loprofit.ShowDialog();
        }

        private void viewBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminbills adbills = new adminbills(); //redirecting to another page.
            adbills.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false; //exit
        }

        private void loginPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(); //redirecting to another page.
            form.ShowDialog();
        }

        private void adminhome_Load(object sender, EventArgs e)
        {

        }
    }
}
