using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace SJD.Web.Picture
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int PicId=(Convert.ToInt32(strid));
					ShowInfo(PicId);
				}
			}
		}
		
	private void ShowInfo(int PicId)
	{
		SJD.BLL.Picture bll=new SJD.BLL.Picture();
		SJD.Model.Picture model=bll.GetModel(PicId);
		this.lblPicId.Text=model.PicId.ToString();
		this.lblPicSrc.Text=model.PicSrc;

	}


    }
}
