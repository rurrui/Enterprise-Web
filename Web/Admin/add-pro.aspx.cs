using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SJD.Web.Admin
{
    public partial class add_pro : MyBasePage
    {
        protected string Route { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            SJD.BLL.Production proBll = new BLL.Production();
            if (!string.IsNullOrEmpty(Request["ptitle"]))
            {
                SJD.Model.Production pro = new Model.Production()
                {
                    ProTitle = Request["ptitle"].ToString(),
                    ProPicSrc = Session["path"].ToString(),
                    ProContent = Request["particle"].ToString(),
                };
                if (proBll.Add(pro) > 0)
                {
                    Response.Redirect("production.aspx");
                }
                else
                {
                    Response.Write("添加失败！！！");
                }
            }

           
        }

        protected void btn_upload_Click(object sender, EventArgs e)
        {
           
        }
    }
}