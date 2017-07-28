using System;
namespace SJD.Model
{
	/// <summary>
	/// Picture:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Picture
	{
		public Picture()
		{}
		#region Model
		private int _picid;
		private string _picsrc;
		/// <summary>
		/// 
		/// </summary>
		public int PicId
		{
			set{ _picid=value;}
			get{return _picid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PicSrc
		{
			set{ _picsrc=value;}
			get{return _picsrc;}
		}
		#endregion Model

	}
}

