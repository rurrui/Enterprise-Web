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
    public partial class Super_UserManager : System.Web.UI.Page
    {
        protected string PageBar { get; set; }
        protected string strHtml { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            SJD.BLL.UserManager userBll = new BLL.UserManager();
           
            DataTable dt = userBll.GetUnionList().Tables[0];

          
            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {
                sb.AppendFormat("<tr ><td style='text-align:center'>{0}</td>" +
                    "<td style='text-align:center'>{1}</td>" +
                    "<td style='text-align:center'>{2}</td>" +
                    "<td style='text-align:center'><a href='edit-user.aspx?id={3}' class='btn btn-success'>修改</a></td>" +
                    "<td style='text-align:center'><a href='javascript:RemoveConfirm({4})' class='btn btn-danger'>删除</a></td></tr>", Convert.ToInt32(row["ManagerId"]), row["ManagerName"].ToString(), row["TypeName"].ToString(), Convert.ToInt32(row["ManagerId"]), Convert.ToInt32(row["ManagerId"]));
            }
            strHtml = sb.ToString();
        }
    }
}