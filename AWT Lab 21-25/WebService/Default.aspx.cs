using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    BankWebService obj = new BankWebService();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "Welcome Mr./Mrs." + obj.getName(TextBox1.Text) + "<br /> Your Account No is " + obj.getAccountNumber(Convert.ToInt32(TextBox2.Text)).ToString();
    }
}