using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using SJD.Model;
namespace SJD.BLL
{
	/// <summary>
	/// Solution
	/// </summary>
	public partial class Solution
	{
		private readonly SJD.DAL.Solution dal=new SJD.DAL.Solution();
		public Solution()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SolutionId)
		{
			return dal.Exists(SolutionId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(SJD.Model.Solution model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SJD.Model.Solution model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int SolutionId)
		{
			
			return dal.Delete(SolutionId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string SolutionIdlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(SolutionIdlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SJD.Model.Solution GetModel(int SolutionId)
		{
			
			return dal.GetModel(SolutionId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public SJD.Model.Solution GetModelByCache(int SolutionId)
		{
			
			string CacheKey = "SolutionModel-" + SolutionId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(SolutionId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (SJD.Model.Solution)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SJD.Model.Solution> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SJD.Model.Solution> DataTableToList(DataTable dt)
		{
			List<SJD.Model.Solution> modelList = new List<SJD.Model.Solution>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				SJD.Model.Solution model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

