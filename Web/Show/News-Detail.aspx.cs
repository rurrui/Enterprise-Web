using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SJD.Web.Show
{
    public partial class News_Detail : System.Web.UI.Page
    {
        protected string strTopSoTitle { get; set; }
        protected string strPTitle { get; set; }
        protected string TM { get; set; }
        protected string TT { get; set; }
        protected string AC { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            SJD.BLL.Production proBll = new BLL.Production();
            DataTable dt = proBll.GetAllList().Tables[0];
            StringBuilder sbPTitle = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {

                //sbTitle.AppendFormat("<li><a href='pro-detail.aspx?id={0}'>{1}</a></li>", Convert.ToInt32(row["ProId"]), row["ProTitle"].ToString());
                sbPTitle.AppendFormat("<dd><a href='pro-detail.aspx?id={0}'>{1}</a></dd>", Convert.ToInt32(row["ProId"]), row["ProTitle"].ToString());
            }
            strPTitle = sbPTitle.ToString();




            SJD.BLL.Solution soBll = new BLL.Solution();
            DataTable dtso = soBll.GetAllList().Tables[0];

            StringBuilder sbTopSoTitle = new StringBuilder();
            foreach (DataRow row in dtso.Rows)
            {

                sbTopSoTitle.AppendFormat("<dd><a href='Solution-Detail.aspx?id={0}'>{1}</a></dd>", Convert.ToInt32(row["SoluTionId"]), row["SolutionTitle"].ToString());
            }

            strTopSoTitle = sbTopSoTitle.ToString();



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