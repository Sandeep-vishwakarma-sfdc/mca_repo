using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

public partial class ConsumerForm : System.Web.UI.Page
{
    ServiceReference1.CalculatorServiceClient cal = new ServiceReference1.CalculatorServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox3.Text = cal.add(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox3.Text = cal.sub(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        TextBox3.Text = cal.mul(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        TextBox3.Text = cal.div(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
    }
}