using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web1:System.Web.UI.Page {
    protected void Page_Load(object sender,EventArgs e) {

    }
    protected void Button1_Click(object sender,EventArgs e) {
        Label2.Text = "Hi" + TextBox1.Text + ",here is the output of the same page post back button:" + Calendar1.SelectedDate.ToString();
    }
    protected void Button2_Click(object sender,EventArgs e) {
        
    }
}