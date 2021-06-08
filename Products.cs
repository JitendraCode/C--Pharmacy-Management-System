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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            this.mediTableAdapter.Fill(this.pharmacyDataSet1.Medi);
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True");//connection with database.
            con.Open();
            String str = "Select max(id) from Medi;";//SQL query
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
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            try
            {
                String str = "Insert into Medi(Id,name,quantity,mfg,exp,box_no,a_no,price,s_id,s_name) values('"+ textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+ textBox6.Text + "','" + textBox7.Text + "','" + textbox77.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "');";//Insertion Query.
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "select max(ID) from Medi;";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Medicine Data SuccessFully..");//message for sucessful data insertion.
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True"))
                    {
                        String str2 = "Select * from Medi";
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);//binding data into dataGridView
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textbox77.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True");//connection of database
            con.Open();
            try
            {
                string getcust = "Select Id,name,quantity,mfg,exp,box_no,a_no,price,s_id,s_name from Medi where id='" + Convert.ToInt32(textBox1.Text) + "';";//retrieving query
                SqlCommand cmd = new SqlCommand(getcust, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox1.Text = dr.GetValue(0).ToString();//Retrieving data using Id.
                    textBox2.Text = dr.GetValue(1).ToString();
                    textBox4.Text = dr.GetValue(2).ToString();
                    textBox5.Text = dr.GetValue(3).ToString();
                    textBox6.Text = dr.GetValue(4).ToString();
                    textBox7.Text = dr.GetValue(5).ToString();
                    textbox77.Text = dr.GetValue(6).ToString();
                    textBox8.Text = dr.GetValue(7).ToString();
                    textBox9.Text = dr.GetValue(8).ToString();
                    textBox10.Text = dr.GetValue(9).ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Medicine Id.");//message if id is inncorrect 
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True");//connection with database
            con.Open();
            try
            {
                string getcust = "update Medi set name='" + textBox2.Text + "',quantity='" + textBox6.Text + "',mfg='" + textBox4.Text + "',exp='" + textBox5.Text + "',box_no='" + textBox7.Text + "',a_no='" + "',price='" + textBox8.Text + "',s_id='" + textBox9.Text + "',s_name='" + textBox10.Text + "' where id='" + textBox1.Text + "'; ";//Updation Query
                SqlCommand cmd = new SqlCommand(getcust, con);
                cmd.ExecuteNonQuery();
                string str1 = "select max(ID) from Medi;";//selection query
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Medicine Data Updated Successfully.");
                    textBox1.Text = "";//Medicine updation
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textbox77.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True")) //database connection.
                    {
                        String str2 = "Select * from Medi";//selection query.
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);//binding data into dataGridView
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Medicine Id.");//message 
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);//message 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True"); //connection to database
            con.Open();
            try
            {
                string str = "delete from Medi where id='" + textBox1.Text + "';"; //deletion Query
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Deleted Successfully."); //message
                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textbox77.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                using (con)
                {
                    String str2 = "Select * from Medi"; //selection Query
                    SqlCommand cmd2 = new SqlCommand(str2, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = new BindingSource(dt, null); //binding database to dataGridView
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); //message box
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]")) //validation for NUMBER ONLY input.
            {
                MessageBox.Show("Please enter only numbers in Medicine Id.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text)) //validation for Not null entries.
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Please enter Name"); //message
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, "");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^0-9]")) //validation for NUMBER ONLY input.
            {
                MessageBox.Show("Please enter only numbers in Medicine Id.");
                textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, "[^0-9]")) //validation for NUMBER ONLY input.
            {
                MessageBox.Show("Please enter valid value in Box No.");
                textBox7.Text = textBox7.Text.Remove(textBox7.Text.Length - 1);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox8.Text, "[^0-9]")) //validation for NUMBER ONLY input.
            {
                MessageBox.Show("Please enter Price in numbers.");
                textBox8.Text = textBox8.Text.Remove(textBox8.Text.Length - 1);
            }
        }

        private void textBox9_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox9.Text, "[^0-9]")) //validation for NUMBER ONLY input.
            {
                MessageBox.Show("Please enter valid Supplier ID");
                textBox9.Text = textBox9.Text.Remove(textBox9.Text.Length - 1);
            }
        }

        private void textBox10_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox10.Text))
            {
                e.Cancel = true;
                textBox10.Focus();
                errorProvider2.SetError(textBox10, "Please enter Supplier Name"); //error message
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox10, "");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"); //date format Validation dd/mm/yyyy
            bool isValid = regex.IsMatch(textBox4.Text.Trim());
            DateTime dt;
            isValid = DateTime.TryParseExact(textBox4.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
            if (!isValid)
            {
                MessageBox.Show("Invalid Date Format"); //message
            }
            else
            {
                MessageBox.Show("Date Entered"); //message
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"); //date format validation
            bool isValid = regex.IsMatch(textBox4.Text.Trim());
            DateTime dt;
            isValid = DateTime.TryParseExact(textBox5.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
            if (!isValid)
            {
                MessageBox.Show("Invalid Date Format"); //message
            }
            else
            {
                MessageBox.Show("Date Entered"); //message
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide(); //back button
        }
    }
}
