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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace SJD.Web.UserManager
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ManagerId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ManagerId);
				}
			}
		}
			
	private void ShowInfo(int ManagerId)
	{
		SJD.BLL.UserManager bll=new SJD.BLL.UserManager();
		SJD.Model.UserManager model=bll.GetModel(ManagerId);
		this.lblManagerId.Text=model.ManagerId.ToString();
		this.txtManagerType.Text=model.ManagerType.ToString();
		this.txtManagerName.Text=model.ManagerName;
		this.txtManagerPwd.Text=model.ManagerPwd;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtManagerType.Text))
			{
				strErr+="ManagerType格式错误！\\n";	
			}
			if(this.txtManagerName.Text.Trim().Length==0)
			{
				strErr+="ManagerName不能为空！\\n";	
			}
			if(this.txtManagerPwd.Text.Trim().Length==0)
			{
				strErr+="ManagerPwd不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ManagerId=int.Parse(this.lblManagerId.Text);
			int ManagerType=int.Parse(this.txtManagerType.Text);
			string ManagerName=this.txtManagerName.Text;
			string ManagerPwd=this.txtManagerPwd.Text;


			SJD.Model.UserManager model=new SJD.Model.UserManager();
			model.ManagerId=ManagerId;
			model.ManagerType=ManagerType;
			model.ManagerName=ManagerName;
			model.ManagerPwd=ManagerPwd;

			SJD.BLL.UserManager bll=new SJD.BLL.UserManager();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
