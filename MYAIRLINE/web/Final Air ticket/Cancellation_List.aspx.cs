using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class Cancellation_List : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataReader dr;
    String s = ConfigurationManager.ConnectionStrings["cc"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(s);
        con.Open();
        cmd = new SqlCommand("Select * from Seat_Cancellation", con);
        dr = cmd.ExecuteReader();
        GridView1.DataSource=dr;
        GridView1.DataBind();
    }
}
