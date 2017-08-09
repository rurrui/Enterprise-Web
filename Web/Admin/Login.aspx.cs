using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SJD.Web.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //session中存储的验证码
                //如果验证码为空返回不执行
                if (Session["ValidateCode"] == null)
                {
                    return;
                }
                //如果输入的验证码和图片验证码相符，继续验证用户名，密码
                if (Request["vcode"].Equals(Session["ValidateCode"].ToString()))
                {
                    SJD.Model.UserManager umModel = new Model.UserManager()
                    {
                        ManagerName = Request["uname"],
                        ManagerPwd = Request["upwd"],
                    };
                    SJD.BLL.UserManager umBll = new BLL.UserManager();
                    int id = 0;
                    int type = 0;
                    if (umBll.Exists(umModel, out id,out type))
                    {
                        Session["ValidateCode"] = null;
                        umModel.ManagerId = id;
                        umModel.ManagerType = type;
                        //标记登录成功
                        Session["UserModel"] = umModel;
                        if (type==1)
                        {
                            Response.Redirect("Super-UserManager.aspx");
                        }
                        else
                        {
                            Response.Redirect("Index.aspx");
                        }
                     
                    }
                    else
                    {
                        //Msg = "用户名或密码错误";
                    }
                }
                else
                {
                    //Msg = "验证码错误";
                }
            }
        }
    }
}