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
namespace SJD.Web.Solution
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
					int SolutionId=(Convert.ToInt32(strid));
					ShowInfo(SolutionId);
				}
			}
		}
		
	private void ShowInfo(int SolutionId)
	{
		SJD.BLL.Solution bll=new SJD.BLL.Solution();
		SJD.Model.Solution model=bll.GetModel(SolutionId);
		this.lblSolutionId.Text=model.SolutionId.ToString();
		this.lblSolutionTitle.Text=model.SolutionTitle;
		this.lblSolutionContent.Text=model.SolutionContent;
		this.lblSolutionPicSrc.Text=model.SolutionPicSrc;

	}


    }
}
