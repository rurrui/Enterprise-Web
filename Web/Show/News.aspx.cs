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
    public partial class News : System.Web.UI.Page
    {
        protected string strTopSoTitle { get; set; }
        protected string strPTitle { get; set; }
        protected string pageBar { get; set; }
        protected string strHtml { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {


            SJD.BLL.Production proBll = new BLL.Production();
            DataTable dt0 = proBll.GetAllList().Tables[0];
            StringBuilder sbPTitle = new StringBuilder();
            foreach (DataRow row in dt0.Rows)
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


            SJD.BLL.News newBll = new BLL.News();
            //分页
            int pageIndex = 1;
            int pageSize = 10;

            if (!string.IsNullOrEmpty(Request["pIndex"]))
            {
                pageIndex = int.Parse(Request["pIndex"]);
            }

            int rowCount = newBll.GetRecordCount("");
            int pageCount = Convert.ToInt32(Math.Ceiling((rowCount * 1.0) / pageSize));

         
            if (pageIndex<=1)
            {
                pageIndex = 1;
            }
            if (pageIndex>=pageCount)
            {
                pageIndex = pageCount;
            }

            int startIndex = (pageIndex - 1) * pageSize + 1;
            int endIndex = pageIndex * pageSize;

            StringBuilder sb1 = new StringBuilder();
            if (pageIndex<=1)
            {
                sb1.AppendFormat("<li><a>首页</a></li><li>上一页</li>");
            }
            else
            {
                sb1.AppendFormat("<li><a href='?pIndex=1'>首页</a></li><li><a href='?pIndex="+(pageIndex-1)+"'>上一页</a></li>");
            }
            if (pageIndex>=pageCount)
            {
                sb1.AppendFormat("<li><a>下一页</a></li><li><a>末页</a></li>");
            }
            else
            {
                sb1.AppendFormat("<li><a href='?pIndex="+(pageIndex+1)+"'>下一页</a></li><li><a href='?pIndex="+pageCount+"'>末页</a></li>");
            }
            pageBar= sb1.ToString();

            DataTable dt = newBll.GetListByPage("", "NewId", startIndex, endIndex).Tables[0];
            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {
                sb.AppendFormat("<li><a href='news-detail.aspx?id={0}'><cite> &nbsp;{1}</cite><span>{2}</span></a></li>",Convert.ToInt32(row["NewId"]),Convert.ToDateTime(row["NewTime"]).ToString("yyyy-MM-dd"),row["NewTitle"].ToString());
               //  < li >< a href = "news-detail.php-id=68.htm" >< cite > &nbsp; 2017 - 06 - 05 </ cite >< span > 公司成功在上交所挂牌上市 </ span ></ a ></ li >
            }
            strHtml = sb.ToString();
        }
    }
}