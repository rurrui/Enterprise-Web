using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SJD.Web.Admin
{
    public partial class edit_solution : MyBasePage
    {
        protected SJD.Model.Solution Model { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            SJD.BLL.Solution soBll = new BLL.Solution();
            if (IsPostBack)
            {
                Model = new SJD.Model.Solution()
                {
                    SolutionTitle = Request["estitle"].ToString(),
                    SolutionContent = Request["esarticle"].ToString(),
                    SolutionPicSrc = null,
                    SolutionId = int.Parse(Request["id"]),
                };
                if (soBll.Update(Model))
                {
                    Response.Redirect("solution.aspx");
                }
                else
                {
                    Response.Write("修改失败");
                }
            }
            else
            {
                int id = int.Parse(Request["id"]);
                Model = soBll.GetModel(id);
            }
        }
    }
}