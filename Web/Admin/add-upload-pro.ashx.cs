using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;

namespace SJD.Web.Admin
{
    /// <summary>
    /// add_upload_pro 的摘要说明
    /// </summary>
    public class add_upload_pro : IHttpHandler,IRequiresSessionState
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
                        string phyPath = context.Server.MapPath("../Admin/productionImg/");

                        string fileName = file.FileName;
                        string fullName = phyPath + fileName;

                        file.SaveAs(fullName);
                        HttpContext.Current.Session["path"] = "../Admin/productionImg/" + fileName;
                        JavaScriptSerializer jser = new JavaScriptSerializer();
                        
                        context.Response.Write(jser.Serialize(new { code = 0, msg = "上传成功", data = new { src = $"../Admin/productionImg/{fileName}", title = fileName } }));
                       // context.Response.Redirect("add-pro.aspx?path=../Admin/productionImg/" + fileName);
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