using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace finalblackbook
{
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            this.suppTableAdapter.Fill(this.pharmacyDataSet.supp);   
            this.suppTableAdapter.Fill(this.pharmacyDataSet.supp);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\PharmacyManagementSystemCSharp\PharmacyManagementSystemCSharp\pharmacy.mdf;Integrated Security=True"); //database connection
            con.Open();
            String str = "Select max(id) from supp;"; //queries
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr = cmd.ExecuteReader();
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True"); //database connectionstring
            con.Open();
            try
            {
                String str = "Insert into supp(Id,name,email,mobile,addr,s_code) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox3.Text + "');"; //insertion query
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "select max(ID) from supp;";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Supplier Data SuccessFully.."); //message
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True")) //database connectionstring
                    {
                        String str2 = "Select * from supp";
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null); //bindng database with dataGridView
                    }
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); //message 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True"); //database connectionstring
            con.Open();
            try
            {
                string getcust = "Select name,email,mobile,addr,s_code from supp where id='" + Convert.ToInt32(textBox1.Text) + "';"; //selection query using where clause for finding data using ID
                SqlCommand cmd = new SqlCommand(getcust, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr.GetValue(0).ToString();
                    textBox3.Text = dr.GetValue(4).ToString();
                    textBox4.Text = dr.GetValue(1).ToString();
                    textBox5.Text = dr.GetValue(2).ToString();
                    textBox6.Text = dr.GetValue(3).ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Supplier Id."); //searching
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); //message
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = ""; //clearing textfields
            textBox3.Text = ""; //clearing textfields
            textBox4.Text = ""; //clearing textfields
            textBox5.Text = ""; //clearing textfields
            textBox6.Text = ""; //clearing textfields
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]")) //Number Only Validator
            {
                MessageBox.Show("Please enter only numbers."); //message
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]")) //Number Only Validator
            {
                MessageBox.Show("Please enter only numbers."); //message
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]")) //Number Only Validator
            {
                MessageBox.Show("Please Valid Values.");//message  
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$"; //email address validation
            if (Regex.IsMatch(textBox4.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textBox4, "Please provoid Valid Mail Address"); //error message
                return;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text)) //not null validator
            {  
                e.Cancel = true;
                textBox2.Focus();
                errorProvider2.SetError(textBox2, "Please enter name of Supplier");//message
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox2, "");//message
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text)) //NOT NUll validator
            {
                e.Cancel = true;
                textBox6.Focus();
                errorProvider3.SetError(textBox6, "Please enter Adress"); //message
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(textBox6, "");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); //back button
        }
    }
}