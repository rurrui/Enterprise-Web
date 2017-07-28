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
namespace SJD.Web.Picture
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int PicId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(PicId);
				}
			}
		}
			
	private void ShowInfo(int PicId)
	{
		SJD.BLL.Picture bll=new SJD.BLL.Picture();
		SJD.Model.Picture model=bll.GetModel(PicId);
		this.lblPicId.Text=model.PicId.ToString();
		this.txtPicSrc.Text=model.PicSrc;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtPicSrc.Text.Trim().Length==0)
			{
				strErr+="PicSrc不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int PicId=int.Parse(this.lblPicId.Text);
			string PicSrc=this.txtPicSrc.Text;


			SJD.Model.Picture model=new SJD.Model.Picture();
			model.PicId=PicId;
			model.PicSrc=PicSrc;

			SJD.BLL.Picture bll=new SJD.BLL.Picture();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
