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
    public partial class lowest : Form
    {
        public lowest()
        {
            InitializeComponent();
        }

        private void lowestprofitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lowestprofitBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet4);

        }

        private void lowest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet4.lowestprofit' table. You can move, or remove it, as needed.
            this.lowestprofitTableAdapter.Fill(this.pharmacyDataSet4.lowestprofit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True"); //connection through coonectionString
            con.Open();
            string users = string.Empty;
            try
            {
                String str = "Insert into lowestprofit(Product_Id,Product_Name) values('" + txtid.Text + "','" + txtname.Text + "');"; //Inserting values into table
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "select max(Product_Id) from lowestprofit;";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Lowest Data SuccessFully.."); //message
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True")) //connection through coonectionString
                    {
                        String str2 = "Select * from lowestprofit"; //selection query
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        lowestprofitDataGridView.DataSource = new BindingSource(dt, null);
                    }
                    txtid.Text = "";
                    txtname.Text = "";
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); //message
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            try
            {
                string getusersorg = "Select Product_Id,Product_Name from lowestprofit where Product_Id='" + Convert.ToInt32(txtid.Text) + "';";
                SqlCommand cmd = new SqlCommand(getusersorg, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtid.Text = dr.GetValue(0).ToString();
                    txtname.Text = dr.GetValue(1).ToString();
                }
                else
                {
                    MessageBox.Show("Invalid User Id.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            try
            {
                string str = "delete from lowestprofit where Product_Id='" + txtid.Text + "';";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("lowest Record Deleted Successfully.");
                txtid.Text = "";
                txtname.Text = "";
                using (con)
                {
                    String str2 = "Select * from lowestprofit";
                    SqlCommand cmd2 = new SqlCommand(str2, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    lowestprofitDataGridView.DataSource = new BindingSource(dt, null);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
        }

        private void txtid_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtid.Text, "[^0-9]")) //Validation for accepting int values
            {
                MessageBox.Show("Please enter only numbers and Valid ProductId.");
                txtid.Text = txtid.Text.Remove(txtid.Text.Length - 1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
