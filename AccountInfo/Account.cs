using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AccountInfo
{
    class Account
    {
        int balance = 1000;
        public void withDraw(int amt)
        {
            balance = balance - amt;
            MessageBox.Show("You withdraw"+amt+" available balance "+balance);
        }
    }
}
