using System;
namespace SJD.Model
{
	/// <summary>
	/// Recruit:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Recruit
	{
		public Recruit()
		{}
		#region Model
		private int _recruitid;
		private string _recruittitle;
		private string _recruitcontent;
		private DateTime? _recruittime;
		/// <summary>
		/// 
		/// </summary>
		public int RecruitId
		{
			set{ _recruitid=value;}
			get{return _recruitid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RecruitTitle
		{
			set{ _recruittitle=value;}
			get{return _recruittitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RecruitContent
		{
			set{ _recruitcontent=value;}
			get{return _recruitcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? RecruitTime
		{
			set{ _recruittime=value;}
			get{return _recruittime;}
		}
		#endregion Model

	}
}

