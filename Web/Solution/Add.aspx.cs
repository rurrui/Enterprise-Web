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
namespace SJD.Web.Solution
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtSolutionTitle.Text.Trim().Length==0)
			{
				strErr+="SolutionTitle不能为空！\\n";	
			}
			if(this.txtSolutionContent.Text.Trim().Length==0)
			{
				strErr+="SolutionContent不能为空！\\n";	
			}
			if(this.txtSolutionPicSrc.Text.Trim().Length==0)
			{
				strErr+="SolutionPicSrc不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string SolutionTitle=this.txtSolutionTitle.Text;
			string SolutionContent=this.txtSolutionContent.Text;
			string SolutionPicSrc=this.txtSolutionPicSrc.Text;

			SJD.Model.Solution model=new SJD.Model.Solution();
			model.SolutionTitle=SolutionTitle;
			model.SolutionContent=SolutionContent;
			model.SolutionPicSrc=SolutionPicSrc;

			SJD.BLL.Solution bll=new SJD.BLL.Solution();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
