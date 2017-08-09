﻿using System;
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
namespace SJD.Web.UserManagerType
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
					int TypeId=(Convert.ToInt32(strid));
					ShowInfo(TypeId);
				}
			}
		}
		
	private void ShowInfo(int TypeId)
	{
		SJD.BLL.UserManagerType bll=new SJD.BLL.UserManagerType();
		SJD.Model.UserManagerType model=bll.GetModel(TypeId);
		this.lblTypeId.Text=model.TypeId.ToString();
		this.lblTypeName.Text=model.TypeName;

	}


    }
}
