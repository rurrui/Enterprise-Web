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
namespace SJD.Web.Production
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
					int ProId=(Convert.ToInt32(strid));
					ShowInfo(ProId);
				}
			}
		}
		
	private void ShowInfo(int ProId)
	{
		SJD.BLL.Production bll=new SJD.BLL.Production();
		SJD.Model.Production model=bll.GetModel(ProId);
		this.lblProId.Text=model.ProId.ToString();
		this.lblProTitle.Text=model.ProTitle;
		this.lblProContent.Text=model.ProContent;
		this.lblProPicSrc.Text=model.ProPicSrc;

	}


    }
}
