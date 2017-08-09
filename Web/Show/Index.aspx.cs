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
    public partial class Index : System.Web.UI.Page
    {
        protected string strNew { get; set; }
        protected string PicSrc { get; set; }
        protected string strTopSoTitle { get; set; }
        protected string strPTitle { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder sbpic = new StringBuilder();

            SJD.BLL.Production proBll = new BLL.Production();
            DataTable dt = proBll.GetAllList().Tables[0];
            StringBuilder sbPTitle = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {
                // < li >
                             //   < a href = "product.php-id=5.htm" >< img src = "images/pro-szzs.jpg" /></ a >


                             //    </ li >

                sbpic.AppendFormat("<li><a href='pro-detail.aspx?id={0}'><img src='{1}'/></a></li>",Convert.ToInt32(row["ProId"]),row["ProPicSrc"].ToString());
                //sbTitle.AppendFormat("<li><a href='pro-detail.aspx?id={0}'>{1}</a></li>", Convert.ToInt32(row["ProId"]), row["ProTitle"].ToString());
                sbPTitle.AppendFormat("<dd><a href='pro-detail.aspx?id={0}'>{1}</a></dd>", Convert.ToInt32(row["ProId"]), row["ProTitle"].ToString());
            }
            PicSrc = sbpic.ToString();
            strPTitle = sbPTitle.ToString();




            SJD.BLL.Solution soBll = new BLL.Solution();
            DataTable dtso = soBll.GetAllList().Tables[0];

            StringBuilder sbTopSoTitle = new StringBuilder();
            foreach (DataRow row in dtso.Rows)
            {

                sbTopSoTitle.AppendFormat("<dd><a href='Solution-Detail.aspx?id={0}'>{1}</a></dd>", Convert.ToInt32(row["SoluTionId"]), row["SolutionTitle"].ToString());
            }

            strTopSoTitle = sbTopSoTitle.ToString();

            StringBuilder sbnew = new StringBuilder();
            SJD.BLL.News newBll = new BLL.News();
            DataTable dtNews = newBll.GetList(5, "", "NewId").Tables[0];
            foreach (DataRow row in dtNews.Rows)
            {
                // < li >< a href = "news-detail.php-id=68.htm" >< cite > 2017 - 06 - 05 </ cite >< h4 > 晋城思及达商贸有限公司 </ h4 ></ a ></ li >
                sbnew.AppendFormat("<li><a href='News-Detail.aspx?id={0}'><cite>{1}</cite><h4>{2}</h4></a></li>",Convert.ToInt32(row["NewId"]),Convert.ToDateTime(row["NewTime"]).ToString("yyyy-MM-dd"),row["NewTitle"].ToString());
            }
            strNew = sbnew.ToString();
        }
    }
}