using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SJD.Web.Admin
{
    public partial class super_add_news : MyBasePage
    {
        protected string Msg { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            SJD.BLL.News newBll = new BLL.News();
            if (!string.IsNullOrEmpty(Request["ntitle"]))
            {
                SJD.Model.News newModle = new Model.News()
                {
                    NewTitle = Request["ntitle"].ToString(),
                    NewContent = Request["acticle"].ToString(),
                    NewTime = DateTime.Now,
                };
                if (newBll.Add(newModle) > 0)
                {
                    Response.Redirect("super-news.aspx");
                }
                else
                {
                    Msg = "添加失败";
                }
            }
        }

    }
}