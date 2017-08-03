using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SJD.Web.Admin
{
    public partial class edit_news : System.Web.UI.Page
    {
        protected SJD.Model.News Model { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            SJD.BLL.News newBll = new BLL.News();
            if (IsPostBack)
            {
                Model = new SJD.Model.News()
                {
                    NewTitle=Request["etitle"].ToString(),
                    NewContent=Request["earticle"],
                    NewTime=DateTime.Now,
                    NewId=int.Parse(Request["id"]),
                };
                if (newBll.Update(Model))
                {
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    Response.Write("修改失败");
                }
            }
            else
            {
                int id = int.Parse(Request["id"]);
                Model = newBll.GetModel(id);
            }  
        }
    }
}