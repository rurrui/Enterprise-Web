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
namespace SJD.Web.UserManagerType
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int TypeId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(TypeId);
				}
			}
		}
			
	private void ShowInfo(int TypeId)
	{
		SJD.BLL.UserManagerType bll=new SJD.BLL.UserManagerType();
		SJD.Model.UserManagerType model=bll.GetModel(TypeId);
		this.lblTypeId.Text=model.TypeId.ToString();
		this.txtTypeName.Text=model.TypeName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtTypeName.Text.Trim().Length==0)
			{
				strErr+="TypeName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int TypeId=int.Parse(this.lblTypeId.Text);
			string TypeName=this.txtTypeName.Text;


			SJD.Model.UserManagerType model=new SJD.Model.UserManagerType();
			model.TypeId=TypeId;
			model.TypeName=TypeName;

			SJD.BLL.UserManagerType bll=new SJD.BLL.UserManagerType();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
