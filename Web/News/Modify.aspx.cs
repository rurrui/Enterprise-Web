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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int NewId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(NewId);
				}
			}
		}
			
	private void ShowInfo(int NewId)
	{
		SJD.BLL.News bll=new SJD.BLL.News();
		SJD.Model.News model=bll.GetModel(NewId);
		this.lblNewId.Text=model.NewId.ToString();
		this.txtNewTitle.Text=model.NewTitle;
		this.txtNewContent.Text=model.NewContent;
		this.txtNewTime.Text=model.NewTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int NewId=int.Parse(this.lblNewId.Text);
			string NewTitle=this.txtNewTitle.Text;
			string NewContent=this.txtNewContent.Text;
			DateTime NewTime=DateTime.Parse(this.txtNewTime.Text);


			SJD.Model.News model=new SJD.Model.News();
			model.NewId=NewId;
			model.NewTitle=NewTitle;
			model.NewContent=NewContent;
			model.NewTime=NewTime;

			SJD.BLL.News bll=new SJD.BLL.News();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
