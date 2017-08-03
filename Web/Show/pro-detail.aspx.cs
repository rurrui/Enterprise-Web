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
    public partial class pro_detail : System.Web.UI.Page
    {
        protected string strPTitle { get; set; }
        protected SJD.Model.Production Model { get; set; }
        protected string strTitle { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            SJD.BLL.Production proBll = new BLL.Production();
            DataTable dt = proBll.GetAllList().Tables[0];
            StringBuilder sbTitle = new StringBuilder();
            StringBuilder sbPTitle = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {
               
                 sbTitle.AppendFormat("<li><a href='pro-detail.aspx?id={0}'>{1}</a></li>", Convert.ToInt32(row["ProId"]), row["ProTitle"].ToString());
                 sbPTitle.AppendFormat("<dd><a href='pro-detail.aspx?id={0}'>{1}</a></dd>",Convert.ToInt32(row["ProId"]),row["ProTitle"].ToString()); 
            }
            strTitle = sbTitle.ToString();
            strPTitle = sbPTitle.ToString();
            if (!string.IsNullOrEmpty(Request["id"]))
            {
                int id = int.Parse(Request["id"]);
                Model = proBll.GetModel(id);
            }
        }
    }
}