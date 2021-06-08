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
    public partial class lowestreport : Form
    {
        public lowestreport()
        {
            InitializeComponent();
        }

        private void lowestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lowestBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet4);

        }

        private void lowestreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet4.lowest' table. You can move, or remove it, as needed.
            this.lowestTableAdapter.Fill(this.pharmacyDataSet4.lowest);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            string users = string.Empty;
            try
            {
                String str = "Insert into lowest(Product_Id,Product_Name) values('" + txtid.Text + "','" + txtname.Text + "');";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "select max(Product_Id) from lowest;";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Lowest Data SuccessFully..");
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True"))
                    {
                        String str2 = "Select * from lowest";
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        lowestDataGridView.DataSource = new BindingSource(dt, null);
                    }
                    txtid.Text = "";
                    txtname.Text = "";
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Desktop\finalblackbook\finalblackbook\pharmacy.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            try
            {
                string getusersorg = "Select Product_Id,Product_Name from lowest where Product_Id='" + Convert.ToInt32(txtid.Text) + "';";
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
                string str = "delete from lowest where Product_Id='" + txtid.Text + "';";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("lowest Record Deleted Successfully.");
                txtid.Text = "";
                txtname.Text = "";
                using (con)
                {
                    String str2 = "Select * from lowest";
                    SqlCommand cmd2 = new SqlCommand(str2, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    lowestDataGridView.DataSource = new BindingSource(dt, null);
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

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtid.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers and Valid Product Id.");
                txtid.Text = txtid.Text.Remove(txtid.Text.Length - 1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
