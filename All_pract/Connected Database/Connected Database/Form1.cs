using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Connected_Database
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataReader dr;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = @"Data Source=.\sqlexpress;initial catalog=mcaprct;Integrated Security=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";

            //int roll = Convert.ToInt16(textBox2.Text);
            conn.Open();
            cmd=new SqlCommand("Select * from student");
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label4.Text += dr[0].ToString()+"\n";

                label5.Text += dr[1].ToString() + "\n";

                label6.Text += dr[2].ToString() + "\n";

            }
            conn.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into student values('"+textBox1.Text+"',"+textBox2.Text+","+textBox3.Text+")");
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Inserted Successfully!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("update student set Stud_Name='"+textBox1.Text+"',Semester=" + textBox3.Text +" where Stud_RollNo= "+textBox2.Text ) ;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Updated Successfully!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("delete from student where Stud_RollNo = " + textBox2.Text);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Deleted Successfully!!!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
