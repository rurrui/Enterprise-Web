using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SJD.Web.Admin
{
    public partial class super_add_solution : MyBasePage
    {
        protected string Msg { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            SJD.BLL.Solution soBll = new BLL.Solution();
            if (!string.IsNullOrEmpty(Request["stitle"]))
            {
                SJD.Model.Solution soModel = new Model.Solution()
                {
                    SolutionTitle = Request["stitle"].ToString(),
                    SolutionContent = Request["sarticle"].ToString(),
                    SolutionPicSrc = null,
                };
                if (soBll.Add(soModel) > 0)
                {
                    Response.Redirect("super-solution.aspx");
                }
                else
                {
                    Msg = "添加失败";
                }
            }
        }
    }
}