using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



/// <summary>
/// Summary description for CourseWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class CourseWebService : System.Web.Services.WebService
{

    public CourseWebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
   public DataSet getCourse()
    {
        string con = ConfigurationManager.ConnectionStrings["mcaprctConnectionString"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(con))
        {
            using (SqlCommand cmd = new SqlCommand("select * from COURSE", conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }
    }
}
