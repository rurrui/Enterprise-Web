using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SJD.Web.Admin
{
    public partial class super_edit_pro : MyBasePage
    {
        protected SJD.Model.Production Model { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            SJD.BLL.Production proBll = new BLL.Production();

            if (IsPostBack)
            {
                Model = new SJD.Model.Production()
                {
                    ProId = int.Parse(Request["id"]),
                    ProTitle = Request["eptitle"].ToString(),
                    ProPicSrc = Session["path"].ToString(),
                    ProContent = Request["eparticle"].ToString(),

                };
                if (proBll.Update(Model))
                {
                    Response.Redirect("super-production.aspx");
                }
                else
                {
                    Response.Write("修改失败！！！");
                }
            }
            else
            {
                int id = int.Parse(Request["id"]);
                Model = proBll.GetModel(id);
            }
        }
    }
}