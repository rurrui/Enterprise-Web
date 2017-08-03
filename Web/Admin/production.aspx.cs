using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SJD.Web.Admin
{
    public partial class production : System.Web.UI.Page
    {
        protected string strHtml { get; set; }
        protected string pageBar { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            SJD.BLL.Production proBll = new BLL.Production();
            //分页
            int pageIndex = 1;
            int pageSize = 10;

            if (!string.IsNullOrEmpty(Request["pIndex"]))
            {
                pageIndex = int.Parse(Request["pIndex"]);
            }
            int rowCount = proBll.GetRecordCount("");
            int pageCount = Convert.ToInt32(Math.Ceiling(rowCount*1.0/pageSize));

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
            DataTable dt = proBll.GetListByPage("", "ProId", startIndex, endIndex).Tables[0];
            StringBuilder sb1 = new StringBuilder();
            if (pageIndex <= 1)
            {
                sb1.AppendFormat("<li><a>首页</a></li><li><a>上一页</a></li>");
            }
            else
            {
                sb1.AppendFormat("<li><a href='?pIndex=1'>首页</a></li><li><a href='?pIndex=" + (pageIndex - 1) + "'>上一页</a></li>");
            }
            if (pageIndex >= pageCount)
            {
                sb1.AppendFormat("<li><a>下一页</a></li><li><a>末页</a></li>");
            }
            else
            {
                sb1.AppendFormat("<li><a href='?pIndex=" + (pageIndex + 1) + "'>下一页</a></li><li><a href='?pIndex=" + pageCount + "'>末页</a></li>");
            }
            pageBar = sb1.ToString();


            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {
                sb.AppendFormat("<tr><td style='text-align:center'>{0}</td>" +
                    "<td style='text-align:center'>{1}</td>" +
                    "<td style='text-align:center'><img src='{2}' style='width:30px;height:30px'/></td>" +
                    "<td style='text-align:center'><a href='edit-pro.aspx?id={3}' class='btn btn-success'>修改</a></td>" +
                    "<td style='text-align:center'><a href='javascript:DeleteConfirm({4})' class='btn btn-danger'>删除</a></td></tr>", Convert.ToInt32(row["ProId"]), row["ProTitle"], row["ProPicSrc"].ToString(), Convert.ToInt32(row["ProId"]), Convert.ToInt32(row["ProId"]));
            }
            strHtml = sb.ToString();
        }
    }
}