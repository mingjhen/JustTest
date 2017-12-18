using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        //建立連接
        SqlConnection myConn = new SqlConnection("Data Source=60.251.66.42;Initial Catalog=IPDB;Persist Security Info=True;User ID=dba;password=dba");
         myConn.Open();
        //打開連接

        SqlCommand cmd = new SqlCommand("SELECT  distinct Country FROM [dbip-country] ", myConn);
       // SqlCommand cmd2 = new SqlCommand("SELECT count(distinct Country) FROM [dbip-country]", myConn);
        TextBox1.Text += "國家\n";
       SqlDataReader dr = cmd.ExecuteReader();
        //SqlDataReader dr2 = cmd2.ExecuteReader();
        while (dr.Read()) {
           // TextBox1.Text += dr["IP_Start"].ToString()+"\t";
            TextBox1.Text += dr["Country"].ToString()+"\n";
        }
        cmd.Cancel();
        dr.Close();
        cmd = new SqlCommand("SELECT  count(distinct Country) FROM [dbip-country] ", myConn);
        
        //dr = cmd.ExecuteReader();
        int c = (int)cmd.ExecuteScalar();
        Label1.Text = "數目 :" + c;
        myConn.Close();
        //關閉連接

    }


    protected void LinkData_Click(object sender, EventArgs e)
    {
        string SC = CountrySearch.Text;
        if (SC != "")
        {
            //建立連接
            SqlConnection myConn = new SqlConnection("Data Source=60.251.66.42;Initial Catalog=IPDB;Persist Security Info=True;User ID=dba;password=dba");
            myConn.Open();
            //打開連接
            SqlCommand cmd = new SqlCommand("SELECT	*   FROM [dbip-country]  where Country = '"+SC+"'", myConn);
            SqlDataReader dr = cmd.ExecuteReader();
            TextBox2.Text = "";
            TextBox2.Visible = true;
            Label2.Visible = true;
            TextBox2.Text += "IP \t\t國家" ;

            while (dr.Read())
            {
                TextBox2.Text += dr["IP_Start"].ToString() + "\t";
                TextBox2.Text += dr["Country"].ToString() + "\n";
            }
            cmd.Cancel();
            dr.Close();
            cmd = new SqlCommand("SELECT  count(*) FROM [dbip-country] where Country = '" + SC + "'", myConn);

            int c = (int)cmd.ExecuteScalar();
            Label2.Text = "數目 :" + c;

            cmd.Cancel();
            myConn.Close();
            //關閉連接
        }
        else {
            TextBox2.Visible = false;
            Label2.Visible = false;
            Response.Write("<Script language='Javascript'>");
            Response.Write("alert('未輸入搜尋國家')");
            Response.Write("</" + "Script>");
        }
    }
        
}