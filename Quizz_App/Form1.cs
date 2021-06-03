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

namespace Quizz_App
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
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
            string q = "select ans from quizz";
            SqlCommand cm = new SqlCommand(q, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int count = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (radioButton2.Checked)
                    {
                        if (radioButton2.Text == row["ans"].ToString())
                        { count++; }
                    }
                    if (radioButton6.Checked)
                    {
                        if (radioButton6.Text == row["ans"].ToString())
                        { count++; }
                    }
                    if (radioButton9.Checked)
                    {
                        if (radioButton9.Text == row["ans"].ToString())
                        { count++; }
                    }
                    if (radioButton16.Checked)
                    {
                        if (radioButton16.Text == row["ans"].ToString())
                        { count++; }
                    }
                }
            label7.Text = count.ToString();
            }
    }
}
