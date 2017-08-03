using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SJD.Web.Admin
{
    public partial class add_user : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SJD.BLL.UserManager userBll = new BLL.UserManager();

            if (!string.IsNullOrEmpty(Request["username"]))
            {
                SJD.Model.UserManager userModel = new Model.UserManager()
                {
                    ManagerName = Request["username"].ToString(),
                    ManagerType = int.Parse(Request["hidden"]),
                    ManagerPwd = Request["pwd"].ToString(),
                };
                if (userBll.Add(userModel) > 0)
                {
                    Response.Redirect("Super-UserManager.aspx");
                }
                else
                {
                    Response.Write("登陆失败！！！");
                }

            }

        }
    }
}