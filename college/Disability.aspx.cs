﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Disability : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["sess"].ToString() == "")
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void drp_Disability_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (drp_Disability.SelectedItem.Text == "YES")
        {
            SqlConnection con = new SqlConnection("server=SACHIN;uid=sa;pwd=sachin1996;database=college");
            SqlDataAdapter dap = new SqlDataAdapter("select * from college_info where c_phys='YES'","server=SACHIN;uid=sa;pwd=sachin1996;database=college");
            DataSet ds = new DataSet();
            dap.Fill(ds);
            GridView4.DataSource = ds.Tables[0];
            GridView4.DataBind();
        }
        else
        {
            SqlConnection con = new SqlConnection("server=SACHIN;uid=sa;pwd=sachin1996;database=college");
            SqlDataAdapter dap = new SqlDataAdapter("select * from college_info where c_phys='NO'","server=SACHIN;uid=sa;pwd=sachin1996;database=college");
            DataSet ds = new DataSet();
            dap.Fill(ds);
            GridView4.DataSource = ds.Tables[0];
            GridView4.DataBind();
        }
    }
}