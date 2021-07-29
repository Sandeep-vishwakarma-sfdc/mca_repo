using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2 {
    public partial class Form1:Form {
        amount obj = new amount();
        public Form1() {
            InitializeComponent();
        }

        private void label2_Click(object sender,EventArgs e) {

        }

        private void Form1_Load(object sender,EventArgs e) {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label5.Visible = false;
            textBox4.Visible = false;
        }

        private void label1_Click(object sender,EventArgs e) {

        }

        private void button3_Click(object sender,EventArgs e) {
            obj.deposite(int.Parse(textBox4.Text));
            textBox4.Text = "";
        }

        private void textBox4_TextChanged(object sender,EventArgs e) {

        }

        private void button1_Click(object sender,EventArgs e) {
            obj.open(int.Parse(textBox3.Text));
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            label5.Visible = true;
            textBox4.Visible = true;
            button1.Visible = false;
            label4.Visible = false;
            textBox3.Visible = false;
        }

        private void button2_Click(object sender,EventArgs e) {
            obj.withdraw(int.Parse(textBox4.Text));
            textBox4.Text = "";
        }

        private void button4_Click(object sender,EventArgs e) {
            obj.checkbalance();
        }
    }
}
