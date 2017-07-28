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
namespace SJD.Web.News
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtNewTitle.Text.Trim().Length==0)
			{
				strErr+="NewTitle不能为空！\\n";	
			}
			if(this.txtNewContent.Text.Trim().Length==0)
			{
				strErr+="NewContent不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtNewTime.Text))
			{
				strErr+="NewTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string NewTitle=this.txtNewTitle.Text;
			string NewContent=this.txtNewContent.Text;
			DateTime NewTime=DateTime.Parse(this.txtNewTime.Text);

			SJD.Model.News model=new SJD.Model.News();
			model.NewTitle=NewTitle;
			model.NewContent=NewContent;
			model.NewTime=NewTime;

			SJD.BLL.News bll=new SJD.BLL.News();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
