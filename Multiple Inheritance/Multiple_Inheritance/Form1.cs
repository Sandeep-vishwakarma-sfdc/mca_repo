using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Inheritance
{
    public partial class Form1 : Form
    {
        int ar;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rec a = new rec(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            ar = a.getarea();
            label4.Text = "Area is :" + ar;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rec a = new rec(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            ar = a.getarea();
            int cost = a.getcost(ar);
            label3.Text+= "\n Cost is: " + cost;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
