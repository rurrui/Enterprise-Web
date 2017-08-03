using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace SJD.Web.Test
{
    /// <summary>
    /// upload 的摘要说明
    /// </summary>
    public class upload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Request.HttpMethod.ToLower() == "post")
            {
                HttpFileCollection files = context.Request.Files;
                for (int i = 0; i < files.Count; i++)
                {
                    HttpPostedFile file = files[i];
                    if (file != null)
                    {
                        string phyPath = context.Server.MapPath("../Test/img/");
                        string fileName = file.FileName;
                        string fullName = phyPath + fileName;

                        file.SaveAs(fullName);

                        JavaScriptSerializer jser = new JavaScriptSerializer();

                        context.Response.Write(jser.Serialize(new { code = 0, msg = "上传成功", data = new { src = $"../Test/img/{fileName}", title = fileName } }));
                    }
                }
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