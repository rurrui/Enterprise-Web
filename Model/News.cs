using System;
namespace SJD.Model
{
	/// <summary>
	/// News:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class News
	{
		public News()
		{}
		#region Model
		private int _newid;
		private string _newtitle;
		private string _newcontent;
		private DateTime? _newtime;
		/// <summary>
		/// 
		/// </summary>
		public int NewId
		{
			set{ _newid=value;}
			get{return _newid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewTitle
		{
			set{ _newtitle=value;}
			get{return _newtitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewContent
		{
			set{ _newcontent=value;}
			get{return _newcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? NewTime
		{
			set{ _newtime=value;}
			get{return _newtime;}
		}
		#endregion Model

	}
}

