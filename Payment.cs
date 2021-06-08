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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            this.payTableAdapter.Fill(this.pharmacyDataSet3.pay);
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True"); //connection through connectionString
            con.Open();
            String str = "Select max(id) from pay;"; //selection Query
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
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True"); //connecting database through connectionString
            con.Open();
            string paymet = string.Empty;
            if (radioButton1.Checked)
            {
                paymet = "Cash"; //selecting data through RadioButton
            }
            else
            {
                paymet = "Online";
            }
            try
            {
                String str = "Insert into pay(Id,s_id,name,mobile,addr,m_name,a_on,price,pay_type) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + paymet + "');"; //insertion query 
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "select max(ID) from pay;"; //selection query
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Payment Data SuccessFully.."); //message
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True")) //connection through connectionString
                    {
                        String str2 = "Select * from pay"; //selection query
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null); //connecting database through dataGridView
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True"); //connecting database through connectionString
            con.Open();
            try
            {
                string getcust = "Select Id,s_id,name,mobile,addr,m_name,a_on,price,pay_type from pay where id='" + Convert.ToInt32(textBox1.Text) + "';"; //select query for searching contents through Id
                SqlCommand cmd = new SqlCommand(getcust, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr.GetValue(0).ToString();
                    textBox3.Text = dr.GetValue(1).ToString();
                    if (dr["pay_type"].ToString() == "Cash")
                    {
                        radioButton1.Checked = true; //retrieving values from RadioButton
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

                }
                else
                {
                    MessageBox.Show("Invalid Payment Id."); //message
                }
            }  
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; //clearing textfields
            textBox2.Text = ""; //clearing textfields
            textBox3.Text = ""; //clearing textfields
            textBox4.Text = ""; //clearing textfields
            textBox5.Text = ""; //clearing textfields
            textBox6.Text = ""; //clearing textfields
            textBox7.Text = ""; //clearing textfields
            textBox8.Text = ""; //clearing textfields
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]")) //validator for accepting only int values.
            {
                MessageBox.Show("Please enter only numbers in payment Id."); //message
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height); //printing GridView Control
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDocument1.Print(); //printing document
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]")) //Validator for accepting only int values
            {
                MessageBox.Show("Please enter only valid Sales Id"); //message
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text)) //validator for not accepting null values.
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
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]")) //Validator for accepting only int values
            {
                MessageBox.Show("Please enter only valid Contact number"); //message
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text)) //validator for not accepting null values.
            {
                e.Cancel = true;
                textBox5.Focus();
                errorProvider2.SetError(textBox5, "Please enter Address"); //message
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox5, "");
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text)) //validator for not accepting null values.
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider3.SetError(textBox6, "Please enter Name"); //message
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(textBox6, "");
            }
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox8.Text, "[^0-9]")) //validator for accepting only Numbers
            {
                MessageBox.Show("Please enter Price"); //message
                textBox8.Text = textBox8.Text.Remove(textBox8.Text.Length - 1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
