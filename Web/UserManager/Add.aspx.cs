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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			int ManagerType=int.Parse(this.txtManagerType.Text);
			string ManagerName=this.txtManagerName.Text;
			string ManagerPwd=this.txtManagerPwd.Text;

			SJD.Model.UserManager model=new SJD.Model.UserManager();
			model.ManagerType=ManagerType;
			model.ManagerName=ManagerName;
			model.ManagerPwd=ManagerPwd;

			SJD.BLL.UserManager bll=new SJD.BLL.UserManager();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
