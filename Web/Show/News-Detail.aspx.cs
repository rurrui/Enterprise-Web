using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SJD.Web.Show
{
    public partial class News_Detail : System.Web.UI.Page
    {
        protected string TM { get; set; }
        protected string TT { get; set; }
        protected string AC { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request["id"]))
            {
                int id = int.Parse(Request["id"]);
                SJD.BLL.News newBll = new BLL.News();

                SJD.Model.News newModel = newBll.GetModel(id);
                TT = newModel.NewTitle;
                TM = Convert.ToDateTime(newModel.NewTime).ToString("yyyy-MM-dd");
                AC= newModel.NewContent;
            }

        }
    }
}