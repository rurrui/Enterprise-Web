using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SJD.Web.Admin
{
    public partial class super_add_recruit : MyBasePage
    {
        protected string Msg { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            SJD.BLL.Recruit reBll = new BLL.Recruit();
            if (!string.IsNullOrEmpty(Request["rtitle"]))
            {
                SJD.Model.Recruit reModel = new SJD.Model.Recruit()
                {
                    RecruitTitle = Request["rtitle"].ToString(),
                    RecruitContent = Request["article"].ToString(),
                    RecruitTime = DateTime.Now,
                };
                if (reBll.Add(reModel) > 0)
                {
                    Response.Redirect("super-recruit.aspx");
                }
                else
                {
                    Response.Write("添加失败！！！");
                }
            }
        }
    }
}