using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;


namespace SJD.Web.Admin
{
    public class MyBasePage:Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["UserModel"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}