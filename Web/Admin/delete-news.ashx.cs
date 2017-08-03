using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SJD.Web.Admin
{
    /// <summary>
    /// delete_news 的摘要说明
    /// </summary>
    public class delete_news : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = int.Parse(context.Request["id"]);
            SJD.BLL.News newBll = new BLL.News();
            if (newBll.Delete(id))
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