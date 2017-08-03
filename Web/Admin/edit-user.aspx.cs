using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SJD.Web.Admin
{
    public partial class edit_user : System.Web.UI.Page
    {
        protected SJD.Model.UserManager Model { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            SJD.BLL.UserManager userBll = new BLL.UserManager();
            if (IsPostBack)
            {
                Model = new SJD.Model.UserManager()
                {
                    ManagerId=int.Parse(Request["id"]),
                    ManagerName=Request["username"].ToString(),
                    ManagerType=int.Parse(Request["hidden"]),
                    ManagerPwd=Request["upwd"].ToString(),
                };
                if (userBll.Update(Model))
                {
                    Response.Redirect("Super-UserManager.aspx");
                }
                else
                {
                    Response.Write("修改失败！！！");
                }
            }
            else
            {
                int id = int.Parse(Request["id"]);
                Model = userBll.GetModel(id);
            }
        }
    }
}