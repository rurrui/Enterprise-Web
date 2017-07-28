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
namespace SJD.Web.UserManager
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
					int ManagerId=(Convert.ToInt32(strid));
					ShowInfo(ManagerId);
				}
			}
		}
		
	private void ShowInfo(int ManagerId)
	{
		SJD.BLL.UserManager bll=new SJD.BLL.UserManager();
		SJD.Model.UserManager model=bll.GetModel(ManagerId);
		this.lblManagerId.Text=model.ManagerId.ToString();
		this.lblManagerType.Text=model.ManagerType.ToString();
		this.lblManagerName.Text=model.ManagerName;
		this.lblManagerPwd.Text=model.ManagerPwd;

	}


    }
}
