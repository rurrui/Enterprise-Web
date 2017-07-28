using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace SJD.DAL
{
	/// <summary>
	/// 数据访问类:UserManager
	/// </summary>
	public partial class UserManager
	{
		public UserManager()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ManagerId", "UserManager"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ManagerId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UserManager");
			strSql.Append(" where ManagerId=@ManagerId");
			SqlParameter[] parameters = {
					new SqlParameter("@ManagerId", SqlDbType.Int,4)
			};
			parameters[0].Value = ManagerId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(SJD.Model.UserManager model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserManager(");
			strSql.Append("ManagerType,ManagerName,ManagerPwd)");
			strSql.Append(" values (");
			strSql.Append("@ManagerType,@ManagerName,@ManagerPwd)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ManagerType", SqlDbType.Int,4),
					new SqlParameter("@ManagerName", SqlDbType.NVarChar,50),
					new SqlParameter("@ManagerPwd", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.ManagerType;
			parameters[1].Value = model.ManagerName;
			parameters[2].Value = model.ManagerPwd;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SJD.Model.UserManager model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserManager set ");
			strSql.Append("ManagerType=@ManagerType,");
			strSql.Append("ManagerName=@ManagerName,");
			strSql.Append("ManagerPwd=@ManagerPwd");
			strSql.Append(" where ManagerId=@ManagerId");
			SqlParameter[] parameters = {
					new SqlParameter("@ManagerType", SqlDbType.Int,4),
					new SqlParameter("@ManagerName", SqlDbType.NVarChar,50),
					new SqlParameter("@ManagerPwd", SqlDbType.NVarChar,50),
					new SqlParameter("@ManagerId", SqlDbType.Int,4)};
			parameters[0].Value = model.ManagerType;
			parameters[1].Value = model.ManagerName;
			parameters[2].Value = model.ManagerPwd;
			parameters[3].Value = model.ManagerId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ManagerId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserManager ");
			strSql.Append(" where ManagerId=@ManagerId");
			SqlParameter[] parameters = {
					new SqlParameter("@ManagerId", SqlDbType.Int,4)
			};
			parameters[0].Value = ManagerId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string ManagerIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserManager ");
			strSql.Append(" where ManagerId in ("+ManagerIdlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SJD.Model.UserManager GetModel(int ManagerId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ManagerId,ManagerType,ManagerName,ManagerPwd from UserManager ");
			strSql.Append(" where ManagerId=@ManagerId");
			SqlParameter[] parameters = {
					new SqlParameter("@ManagerId", SqlDbType.Int,4)
			};
			parameters[0].Value = ManagerId;

			SJD.Model.UserManager model=new SJD.Model.UserManager();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SJD.Model.UserManager DataRowToModel(DataRow row)
		{
			SJD.Model.UserManager model=new SJD.Model.UserManager();
			if (row != null)
			{
				if(row["ManagerId"]!=null && row["ManagerId"].ToString()!="")
				{
					model.ManagerId=int.Parse(row["ManagerId"].ToString());
				}
				if(row["ManagerType"]!=null && row["ManagerType"].ToString()!="")
				{
					model.ManagerType=int.Parse(row["ManagerType"].ToString());
				}
				if(row["ManagerName"]!=null)
				{
					model.ManagerName=row["ManagerName"].ToString();
				}
				if(row["ManagerPwd"]!=null)
				{
					model.ManagerPwd=row["ManagerPwd"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ManagerId,ManagerType,ManagerName,ManagerPwd ");
			strSql.Append(" FROM UserManager ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ManagerId,ManagerType,ManagerName,ManagerPwd ");
			strSql.Append(" FROM UserManager ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM UserManager ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ManagerId desc");
			}
			strSql.Append(")AS Row, T.*  from UserManager T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "UserManager";
			parameters[1].Value = "ManagerId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

