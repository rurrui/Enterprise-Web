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
    public partial class Production : System.Web.UI.Page
    {
        protected string strTopSoTitle { get; set; }
        protected string strPTitle { get; set; }
        protected SJD.Model.Production pModel { get; set; }
        protected string strHtml { get; set; }
        protected string strTitle { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            SJD.BLL.Solution soBll = new BLL.Solution();
            DataTable dtso = soBll.GetAllList().Tables[0];

            StringBuilder sbTopSoTitle = new StringBuilder();
            foreach (DataRow row in dtso.Rows)
            {

                sbTopSoTitle.AppendFormat("<dd><a href='Solution-Detail.aspx?id={0}'>{1}</a></dd>", Convert.ToInt32(row["SoluTionId"]), row["SolutionTitle"].ToString());
            }

            strTopSoTitle = sbTopSoTitle.ToString();





            SJD.BLL.Production proBll = new BLL.Production();
            DataTable dt = proBll.GetAllList().Tables[0];
            StringBuilder sbTitle = new StringBuilder();
            StringBuilder sbPTitle = new StringBuilder();
            foreach  (DataRow row in dt.Rows)
            {
             
                sbTitle.AppendFormat("<li><a href='pro-detail.aspx?id={0}'>{1}</a></li>",Convert.ToInt32(row["ProId"]),row["ProTitle"].ToString());
                sbPTitle.AppendFormat("<dd><a href='pro-detail.aspx?id={0}'>{1}</a></dd>", Convert.ToInt32(row["ProId"]), row["ProTitle"].ToString());
            }
            strTitle = sbTitle.ToString();
            strPTitle = sbPTitle.ToString();
            StringBuilder sbarticle = new StringBuilder();
            SJD.Model.Production pro = proBll.GetModel(1);
            pModel = pro;
            sbarticle.AppendFormat("<h2>{0}</h2><div class='detail-cont'>{1}</div>",pro.ProTitle,pro.ProContent);
            strHtml = sbarticle.ToString();  
        }
    }
}