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
    public partial class usersoforg : Form
    {
        public usersoforg()
        {
            InitializeComponent();
        }

        private void usersorgBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersorgBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet5);

        }

        private void usersoforg_Load(object sender, EventArgs e)
        {
            this.usersorgTableAdapter.Fill(this.pharmacyDataSet5.usersorg);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True");//connection through connectionString
            con.Open();
            string users = string.Empty;
            try
            {
                String str = "Insert into usersorg(UserId,Name_Of_User,Time_Duration,Service_Charges) values('" + txtid.Text + "','" + txtuser.Text + "','" + txttimeduration.Text + "','" + txtservice.Text + "');"; //insertion query
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "select max(UserId) from usersorg;";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Users Data SuccessFully.."); //message
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True"))
                    {
                        String str2 = "Select * from usersorg"; //selection query
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        usersorgDataGridView.DataSource = new BindingSource(dt, null);
                    }
                    txtid.Text = "";
                    txtuser.Text = "";
                    txttimeduration.Text = "";
                    txtservice.Text = "";

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True"); //connection through connectionString
            con.Open();
            try
            {
                string getusersorg = "Select UserId,Name_Of_User,Time_Duration,Service_Charges from usersorg where UserId='" + Convert.ToInt32(txtid.Text) + "';"; //retrieving code
                SqlCommand cmd = new SqlCommand(getusersorg, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtid.Text = dr.GetValue(0).ToString();
                    txtuser.Text = dr.GetValue(1).ToString();
                    txttimeduration.Text = dr.GetValue(2).ToString();
                    txtservice.Text = dr.GetValue(3).ToString();
                }
                else
                {
                    MessageBox.Show("Invalid User Id."); // message
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); //message 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True"); //connection through connectionString
            con.Open();
            try
            {
                string str = "delete from usersorg where UserId='" + txtid.Text + "';"; //delete query
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sales Record Deleted Successfully."); //message
                txtid.Text = "";
                txtuser.Text = "";
                txttimeduration.Text = "";
                txtservice.Text = "";
                using (con)
                {
                    String str2 = "Select * from usersorg"; //selection query
                    SqlCommand cmd2 = new SqlCommand(str2, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    usersorgDataGridView.DataSource = new BindingSource(dt, null); //binding datasource to GridView
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); //message 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtid.Text = ""; //clearing text fields
            txtuser.Text = ""; //clearing text fields
            txttimeduration.Text = ""; //clearing text fields
            txtservice.Text = ""; //clearing text fields
          }

        private void txtid_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtid.Text, "[^0-9]")) //validator for only accepting int values
            {
                MessageBox.Show("Please enter Valid UserId."); //message
                txtid.Text = txtid.Text.Remove(txtid.Text.Length - 1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide(); //back button
        }
    }
}
