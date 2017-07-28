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
namespace SJD.Web.Recruit
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtRecruitTitle.Text.Trim().Length==0)
			{
				strErr+="RecruitTitle不能为空！\\n";	
			}
			if(this.txtRecruitContent.Text.Trim().Length==0)
			{
				strErr+="RecruitContent不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtRecruitTime.Text))
			{
				strErr+="RecruitTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string RecruitTitle=this.txtRecruitTitle.Text;
			string RecruitContent=this.txtRecruitContent.Text;
			DateTime RecruitTime=DateTime.Parse(this.txtRecruitTime.Text);

			SJD.Model.Recruit model=new SJD.Model.Recruit();
			model.RecruitTitle=RecruitTitle;
			model.RecruitContent=RecruitContent;
			model.RecruitTime=RecruitTime;

			SJD.BLL.Recruit bll=new SJD.BLL.Recruit();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
