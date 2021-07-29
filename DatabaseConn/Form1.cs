using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DatabaseConn
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataReader dr;
        SqlCommand cmd; 

        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=(localdb)\\MyInstance;Initial Catalog=master;Integrated Security=True";
            con.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int roll = Convert.ToInt16(textBox2.Text);
            cmd = new SqlCommand("select * from  StudentInfo  where roll='" + roll + "'", con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label4.Text = dr[0].ToString();
                label5.Text = dr[1].ToString();
                label6.Text = dr[2].ToString();
            }
            dr.Close();
            MessageBox.Show("data selected sucessfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nm, sem;
            int roll;
            nm = textBox1.Text;
            roll = Convert.ToInt16(textBox2.Text);
            sem = textBox3.Text;
            string qry = "insert into StudentInfo(Name,roll,sem) values('" + nm + "'," + roll + ",'" + sem + "')";
            cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data inserted sucessfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nm, sem;
            int roll;
            nm = textBox1.Text;
            roll = Convert.ToInt16(textBox2.Text);
            sem = textBox3.Text;
            cmd = new SqlCommand("update StudentInfo set name='" + nm + "',sem='" + sem + "' where roll='" + roll + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data updated sucessfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int roll = Convert.ToInt16(textBox2.Text);
            cmd = new SqlCommand("delete from  StudentInfo  where roll='" + roll + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data deleted sucessfully");
        }
    }
}
