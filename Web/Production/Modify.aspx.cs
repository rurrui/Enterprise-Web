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
namespace SJD.Web.Production
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ProId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ProId);
				}
			}
		}
			
	private void ShowInfo(int ProId)
	{
		SJD.BLL.Production bll=new SJD.BLL.Production();
		SJD.Model.Production model=bll.GetModel(ProId);
		this.lblProId.Text=model.ProId.ToString();
		this.txtProTitle.Text=model.ProTitle;
		this.txtProContent.Text=model.ProContent;
		this.txtProPicSrc.Text=model.ProPicSrc;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtProTitle.Text.Trim().Length==0)
			{
				strErr+="ProTitle不能为空！\\n";	
			}
			if(this.txtProContent.Text.Trim().Length==0)
			{
				strErr+="ProContent不能为空！\\n";	
			}
			if(this.txtProPicSrc.Text.Trim().Length==0)
			{
				strErr+="ProPicSrc不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ProId=int.Parse(this.lblProId.Text);
			string ProTitle=this.txtProTitle.Text;
			string ProContent=this.txtProContent.Text;
			string ProPicSrc=this.txtProPicSrc.Text;


			SJD.Model.Production model=new SJD.Model.Production();
			model.ProId=ProId;
			model.ProTitle=ProTitle;
			model.ProContent=ProContent;
			model.ProPicSrc=ProPicSrc;

			SJD.BLL.Production bll=new SJD.BLL.Production();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
