using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqToSql {
    public partial class ProductData:System.Web.UI.Page {
        protected void Page_Load(object sender,EventArgs e) {

        }
        protected void Button1_Click1(object sender,EventArgs e) {
            var d = new DataClassesDataContext();
            var c = new Product();
            c.P_Name = TextBox1.Text;
            c.P_Price = Convert.ToInt16(TextBox2.Text);

            d.Products.InsertOnSubmit(c);
            d.SubmitChanges();
            Label1.Text = "Successfully Added Data";
        }

        protected void Button2_Click(object sender,EventArgs e) {
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender,EventArgs e) {
            var d = new DataClassesDataContext();
            Product c = d.Products.FirstOrDefault(e1 => e1.P_Name.Equals(TextBox1.Text));
            c.P_Name = TextBox1.Text;
            d.Products.DeleteOnSubmit(c);
            d.SubmitChanges();
            Label1.Text = "Successfully Deleted Data";
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender,EventArgs e) {
            var d = new DataClassesDataContext();
            Product c = d.Products.FirstOrDefault(e1 => e1.P_Name.Equals(TextBox1.Text));
            c.P_Name = TextBox1.Text;
            c.P_Price = Convert.ToInt16(TextBox2.Text);
            d.SubmitChanges();
            Label1.Text = "Successfully Updated Data";
            GridView1.DataBind();
        }
    }
}