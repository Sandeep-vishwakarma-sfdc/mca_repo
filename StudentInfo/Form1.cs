using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentInfo {
    public partial class Form1:Form {
        SqlConnection conn = new SqlConnection();
        SqlDataReader dr;
        SqlCommand cmd;
        public Form1() {
            InitializeComponent();
            conn.ConnectionString = "Data Source=(localdb)\\MyInstance;Initial Catalog=master;Integrated Security=True";
        }

        private void button1_Click(object sender,EventArgs e) {
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";

            //int roll = Convert.ToInt16(textBox2.Text);
            conn.Open();
            cmd = new SqlCommand("Select * from Studentinfo where roll =" + textBox2.Text);
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            while (dr.Read()) {
                label4.Text += dr[0].ToString() + "\n";

                label5.Text += dr[1].ToString() + "\n";

                label6.Text += dr[2].ToString() + "\n";

            }
            conn.Close();

        }

        private void button2_Click(object sender,EventArgs e) {
            conn.Open();
            cmd = new SqlCommand("insert into StudentInfo values('" + textBox1.Text + "'," + textBox2.Text + "," + textBox3.Text + ")");
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Inserted Successfully!!!");
        }

        private void button3_Click(object sender,EventArgs e) {
            conn.Open();
            cmd = new SqlCommand("update StudentInfo set Name='" + textBox1.Text + "',Sem=" + textBox3.Text + " where roll= " + textBox2.Text);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Updated Successfully!!!");
        }

        private void button4_Click(object sender,EventArgs e) {
            conn.Open();
            cmd = new SqlCommand("delete from StudentInfo where roll = " + textBox2.Text);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Deleted Successfully!!!");
        }

        private void Form1_Load(object sender,EventArgs e) {

        }
    }
}
