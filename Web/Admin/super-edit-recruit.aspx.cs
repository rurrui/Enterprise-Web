using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SJD.Web.Admin
{
    public partial class super_edit_recruit : MyBasePage
    {
        protected SJD.Model.Recruit Model { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            SJD.BLL.Recruit reBll = new BLL.Recruit();
            if (IsPostBack)
            {
                Model = new SJD.Model.Recruit
                {
                    RecruitTitle = Request["ertitle"].ToString(),
                    RecruitContent = Request["earticle"],
                    RecruitTime = DateTime.Now,
                    RecruitId = int.Parse(Request["id"]),
                };
                if (reBll.Update(Model))
                {
                    Response.Redirect("super-recruit.aspx");
                }
                else
                {
                    Response.Write("修改失败");
                }
            }
            else
            {
                int id = int.Parse(Request["id"]);
                Model = reBll.GetModel(id);
            }
        }
    }
}