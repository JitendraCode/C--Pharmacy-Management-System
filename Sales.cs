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
using System.Globalization;

namespace finalblackbook
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            this.salesTableAdapter.Fill(this.pharmacyDataSet2.sales);
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True"); //database connectionString
            con.Open();
            String str = "Select max(id) from sales;"; //select query
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
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True"); //database connectionString
            con.Open();
            string gen = string.Empty;
            if (radioButton1.Checked) //selecting values from Radiobutton
            {
                gen = "Male"; //male
            }
            else
            {
                gen = "Female"; //female
            }
            try
            {
                String str = "Insert into sales(Id,c_id,name,gen,mob,addr,m_id,m_name,mfg,exp,a_on,price) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + gen + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "');"; //database connectionString
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "select max(ID) from sales;"; //selection query
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Sales Data SuccessFully.."); //message 
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True")) //database connectionString
                    {
                        String str2 = "Select * from sales"; //selection query
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null); //binding database with dataGridView
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); //message 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True"); //database connectionString
            con.Open();
            try
            {
                string getcust = "Select Id,c_id,name,gen,mob,addr,m_id,m_name,mfg,exp,a_on,price from sales where id='" + Convert.ToInt32(textBox1.Text) + "';"; //query for retrieving data from database through Id using where caluse
                SqlCommand cmd = new SqlCommand(getcust, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr.GetValue(0).ToString();
                    textBox3.Text = dr.GetValue(1).ToString();
                    if (dr["gen"].ToString() == "Male") //Radio button data
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }
                    textBox4.Text = dr.GetValue(3).ToString();
                    textBox5.Text = dr.GetValue(4).ToString();
                    textBox6.Text = dr.GetValue(5).ToString();
                    textBox7.Text = dr.GetValue(6).ToString();
                    textBox8.Text = dr.GetValue(7).ToString();
                    textBox9.Text = dr.GetValue(8).ToString();
                    textBox10.Text = dr.GetValue(9).ToString();
                    textBox11.Text = dr.GetValue(10).ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); //messsage 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True"); //database connection with connectionString 
            con.Open();
            string gen = string.Empty;
            if (radioButton1.Checked) //updation of Radio button data 
            {
                gen = "Male";
            }
            else
            {
                gen = "Female";
            }
            try
            {
                string getcust = "update sales set c_id='" + textBox2.Text + "',name='" + textBox3.Text + "',gen='" + gen + "',mob='" + textBox4.Text + "',addr='" + textBox5.Text + "',m_id='" + textBox6.Text + "',m_name='" + textBox7.Text + "',mfg='" + textBox8.Text + "',exp='" + textBox9.Text + "',a_on='" + textBox10.Text + "',price='" + textBox11.Text + "' where id='" + textBox1.Text + "'; "; //select query to update contents
                SqlCommand cmd = new SqlCommand(getcust, con);
                cmd.ExecuteNonQuery();
                string str1 = "select max(ID) from sales;";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Sales Data Updated Successfully."); //message 
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True")) //database connectionString 
                    {
                        String str2 = "Select * from sales"; //selection query 
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null); //binding data with dataGridView
                    }
                }
                else
                {  
                    MessageBox.Show("Invalid Sales Id."); //message
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); //message 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True"); //database connectionString
            con.Open();
            try
            {
                string str = "delete from sales where id='" + textBox1.Text + "';"; //delete query for deleting contents
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery(); //executing 
                MessageBox.Show("Sales Record Deleted Successfully."); //message
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                using (con)
                {
                    String str2 = "Select * from sales"; //selection query
                    SqlCommand cmd2 = new SqlCommand(str2, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = new BindingSource(dt, null); //binding database to gridViewControl
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); //message
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]")) //Validator for only int values
            {
                MessageBox.Show("Please enter only numbers in sales Id."); //message 
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]")) //Validator for only int values
            {
                MessageBox.Show("Please enter only numbers in Customer Id."); //message 
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text)) //Validator for no null values
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Please enter Name"); //message
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox3, "");
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]")) //Validator for only int values
            {
                MessageBox.Show("Please enter valid mobile number"); //message 
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text)) //Validator for not null input
            {
                e.Cancel = true;
                textBox5.Focus();
                errorProvider2.SetError(textBox5, "Please enter Name"); //message 
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox5, "");
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^0-9]")) //Validator for only int values
            {
                MessageBox.Show("Please enter only numbers in Medicine ID"); //message
                textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
            }
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))//Validator for no null inputs
            {
                e.Cancel = true;
                textBox7.Focus();
                errorProvider3.SetError(textBox7, "Please enter Medicine Name"); //message
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(textBox7, "");
            }
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"); //Validator for date DD/MM/YYYY
            bool isValid = regex.IsMatch(textBox8.Text.Trim());
            DateTime dt;
            isValid = DateTime.TryParseExact(textBox8.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
            if (!isValid)
            {
                MessageBox.Show("Invalid Date Format"); //message
            }
            else
            {
                MessageBox.Show("Date Entered"); //message
            }
        }

        private void textBox9_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"); //Validator for date DD/MM/YYYY
            bool isValid = regex.IsMatch(textBox8.Text.Trim());
            DateTime dt;
            isValid = DateTime.TryParseExact(textBox8.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
            if (!isValid)
            {
                MessageBox.Show("Invalid Date Format"); //message 
            }
            else
            {
                MessageBox.Show("Date Entered"); //message 
            }
        }

        private void textBox11_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox11.Text))//Validator for no null values
            {
                e.Cancel = true;
                textBox11.Focus();
                errorProvider4.SetError(textBox11, "Please enter Price"); //message 
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(textBox11, "");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide(); //backbutton
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
        }
    }
