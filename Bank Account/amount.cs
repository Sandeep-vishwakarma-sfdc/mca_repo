using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2 {

    class amount {
        int balance = 0;
        public void open(int amount) {
            int amt = amount;
            balance += amt;
            MessageBox.Show("Successfully open account");
        }
        public void withdraw(int amount) {
            balance -= amount;
            MessageBox.Show("Successfully withdraw, amount remaining:" + balance);
        }
        public void deposite(int amount) {
            balance += amount;
            MessageBox.Show("Successfully deposited, balance amount:" + balance);
        }
        public void checkbalance() {

            MessageBox.Show("Available balance is" + balance);
        }
    }
}
