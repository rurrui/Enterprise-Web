using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SJD.Web
{
    /// <summary>
    /// delete_recruit 的摘要说明
    /// </summary>
    public class delete_recruit : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = int.Parse(context.Request["id"]);
            SJD.BLL.Recruit reBll = new BLL.Recruit();
            if (reBll.Delete(id))
            {
                context.Response.Write(1);
            }
            else
            {
                context.Response.Write(0);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}