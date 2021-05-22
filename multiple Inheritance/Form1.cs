using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiple_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rec = new Rectangle(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            int area = rec.getArea();
            label3.Text = label3.Text + area;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Rectangle rec = new Rectangle(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            int cost = rec.getCost(Convert.ToInt32(textBox1.Text));
            label4.Text = label4.Text + cost;
        }

       
    }
}
