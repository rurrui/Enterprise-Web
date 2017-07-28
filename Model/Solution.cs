using System;
namespace SJD.Model
{
	/// <summary>
	/// Solution:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Solution
	{
		public Solution()
		{}
		#region Model
		private int _solutionid;
		private string _solutiontitle;
		private string _solutioncontent;
		private string _solutionpicsrc;
		/// <summary>
		/// 
		/// </summary>
		public int SolutionId
		{
			set{ _solutionid=value;}
			get{return _solutionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SolutionTitle
		{
			set{ _solutiontitle=value;}
			get{return _solutiontitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SolutionContent
		{
			set{ _solutioncontent=value;}
			get{return _solutioncontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SolutionPicSrc
		{
			set{ _solutionpicsrc=value;}
			get{return _solutionpicsrc;}
		}
		#endregion Model

	}
}

