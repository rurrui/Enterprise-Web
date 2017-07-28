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
namespace SJD.Web.News
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
					int NewId=(Convert.ToInt32(strid));
					ShowInfo(NewId);
				}
			}
		}
		
	private void ShowInfo(int NewId)
	{
		SJD.BLL.News bll=new SJD.BLL.News();
		SJD.Model.News model=bll.GetModel(NewId);
		this.lblNewId.Text=model.NewId.ToString();
		this.lblNewTitle.Text=model.NewTitle;
		this.lblNewContent.Text=model.NewContent;
		this.lblNewTime.Text=model.NewTime.ToString();

	}


    }
}
