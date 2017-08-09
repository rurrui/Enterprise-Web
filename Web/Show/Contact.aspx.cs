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
    public partial class Contact : System.Web.UI.Page
    {
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
        }
    }
}