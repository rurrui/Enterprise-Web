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
namespace SJD.Web.Recruit
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
					int RecruitId=(Convert.ToInt32(strid));
					ShowInfo(RecruitId);
				}
			}
		}
		
	private void ShowInfo(int RecruitId)
	{
		SJD.BLL.Recruit bll=new SJD.BLL.Recruit();
		SJD.Model.Recruit model=bll.GetModel(RecruitId);
		this.lblRecruitId.Text=model.RecruitId.ToString();
		this.lblRecruitTitle.Text=model.RecruitTitle;
		this.lblRecruitContent.Text=model.RecruitContent;
		this.lblRecruitTime.Text=model.RecruitTime.ToString();

	}


    }
}
