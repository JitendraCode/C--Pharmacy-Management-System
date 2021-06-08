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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "user" && textBox2.Text == "user")//Username and Password for User
            {
                MessageBox.Show("You are logged in successfully..");//showing message
                this.Visible = false;
                Home obj1 = new Home();//takes you to the User Home Page.
                obj1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password.");//showing message
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";//clearing textfields
            textBox2.Text = "";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")//Username and Password for Admin.
            {
                MessageBox.Show("You are logged in successfully..");//Showing Message.
                this.Visible = false;
                adminhome admin = new adminhome();
                admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password.");
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Username should not be left blank!");//if null then interrupt with message.
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider2.SetError(textBox2, "Password should not be left blank!");//doesnot accepts null values
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox2, "");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}