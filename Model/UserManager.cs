using System;
namespace SJD.Model
{
	/// <summary>
	/// UserManager:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UserManager
	{
		public UserManager()
		{}
		#region Model
		private int _managerid;
		private int? _managertype;
		private string _managername;
		private string _managerpwd;
		/// <summary>
		/// 
		/// </summary>
		public int ManagerId
		{
			set{ _managerid=value;}
			get{return _managerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ManagerType
		{
			set{ _managertype=value;}
			get{return _managertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ManagerName
		{
			set{ _managername=value;}
			get{return _managername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ManagerPwd
		{
			set{ _managerpwd=value;}
			get{return _managerpwd;}
		}
		#endregion Model

	}
}

