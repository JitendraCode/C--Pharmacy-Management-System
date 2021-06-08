using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace finalblackbook
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True");//SQL database connection.
            con.Open();//opens connection
            string gen = string.Empty;
            if (radioButton1.Checked)
            {
                gen = "Male";
            }
            else
            {
                gen = "Female";
            }
            try
            {
                String str = "Insert into cust(id,name,gen,mob,addr) values('" + textBox1.Text + "','" + textBox2.Text + "','" + gen + "','" + textBox3.Text + "','" + textBox4.Text + "');";//Insertion of values into database respective of Textboxes.
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "select max(ID) from cust;";//SQL Query for selection.
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Customer Data SuccessFully..");//Message of Data Sucessfully entered.
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet7.cust' table. You can move, or remove it, as needed.
            this.custTableAdapter.Fill(this.pharmacyDataSet7.cust);
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            String str = "Select max(id) from cust;";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr = cmd.ExecuteReader();//Connection with database
            if (dr.Read())
            {
                String val = dr[0].ToString();
                if (val == "")
                {
                    textBox1.Text = "1";
                }
                else
                {
                    int a;
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    textBox1.Text = a.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            try
            {
                string getcust = "Select name,gen,mob,addr from cust where id='" + Convert.ToInt32(textBox1.Text) + "';";//Selection Query with where caluse.
                SqlCommand cmd = new SqlCommand(getcust, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr.GetValue(0).ToString();//searching for ID in database
                    textBox3.Text = dr.GetValue(2).ToString();//searching for ID in database
                    textBox4.Text = dr.GetValue(3).ToString();//searching for ID in database
                    if (dr["gen"].ToString() == "Male")
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Id.");//checking values and giving messages
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";//Clearing textfields
            textBox2.Text = "";//Clearing textfields
            textBox3.Text = "";//Clearing textfields
            textBox4.Text = "";//Clearing textfields
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");//Validation for Id
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter Valid values.");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);//Validations
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider2.SetError(textBox2, "Please enter name of the Customer");//Validation using error providers
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox2, "");
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                e.Cancel = true;
                textBox4.Focus();
                errorProvider2.SetError(textBox4, "Please enter Address!");//not null validation using errror provider
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox4, "");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();//back button
        }

        private void custBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.custBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet7);

        }
    }
}
        
