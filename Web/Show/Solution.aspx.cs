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

    public partial class Solution : System.Web.UI.Page
    {
        protected SJD.Model.Solution Model { get; set; }
        protected string strPTitle { get; set; }
        protected string strSoTitle { get; set; }
        protected string strTopSoTitle { get; set; }
        protected string strHtml { get; set; }
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
            StringBuilder sbSoTitle = new StringBuilder();
            StringBuilder sbTopSoTitle = new StringBuilder();
            foreach (DataRow row in dtso.Rows)
            {
                sbSoTitle.AppendFormat("<li><a href='Solution-Detail.aspx?id={0}'>{1}</a></li>",Convert.ToInt32(row["SolutionId"]),row["SolutionTitle"].ToString());
                sbTopSoTitle.AppendFormat("<dd><a href='Solution-Detail.aspx?id={0}'>{1}</a></dd>",Convert.ToInt32(row["SoluTionId"]),row["SolutionTitle"].ToString());
            }
            strSoTitle = sbSoTitle.ToString();
            strTopSoTitle = sbTopSoTitle.ToString();

            SJD.Model.Solution soModel = soBll.GetModel(1);
            Model = soModel;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<h2>{0}</h2><div class='detail-cont'>{1}</div>", soModel.SolutionTitle,soModel.SolutionContent);
            strHtml = sb.ToString();
        }
    }
}