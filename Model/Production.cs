using System;
namespace SJD.Model
{
	/// <summary>
	/// Production:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Production
	{
		public Production()
		{
            
        }
		#region Model
		private int _proid;
		private string _protitle;
		private string _procontent;
		private string _propicsrc;
		/// <summary>
		/// 
		/// </summary>
		public int ProId
		{
			set{ _proid=value;}
			get{return _proid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProTitle
		{
			set{ _protitle=value;}
			get{return _protitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProContent
		{
			set{ _procontent=value;}
			get{return _procontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProPicSrc
		{
			set{ _propicsrc=value;}
			get{return _propicsrc;}
		}
		#endregion Model

	}
}

