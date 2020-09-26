using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.Common;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Class1
/// </summary>
public static class Class1
{
    public static string sc = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
    public static DataSet select(string strquery)
    {
        SqlConnection con = new SqlConnection(sc);
        con.Open();
        SqlCommand cmd = new SqlCommand(strquery, con);
        DataSet ds = new DataSet();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        adp.Fill(ds);
        return ds;
        con.Close();
    }
    public static int exQuery(string strquery)
    {
        SqlConnection con = new SqlConnection(sc);
        con.Open();
        SqlCommand cmd = new SqlCommand(strquery, con);
        int i;
        i = cmd.ExecuteNonQuery();
        return i;
        con.Close();
    }
}
