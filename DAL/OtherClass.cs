using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJD.DAL
{
   public partial class Picture:SJD.IDal.IPicture
    {

    }
    public partial class News : SJD.IDal.INews
    {

    }
    public partial class Production : SJD.IDal.IProduction
    {

    }
    public partial class Solution : SJD.IDal.ISolution
    {

    }
    public partial class UserManager : SJD.IDal.IUserManager
    {
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetUnionList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("select m.*,n.* from UserManager as m,UserManagerType as n where m.ManagerType=n.TypeId");
            
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(SJD.Model.UserManager model, out int id,out int type)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from UserManager");
            strSql.Append(" where UserName=@name and UserPwd=@pwd");
            SqlParameter[] parameters = {
                    new SqlParameter("@name", SqlDbType.NVarChar, 50)
                    {
                        Value=model.ManagerName
                    },
                    new SqlParameter("@pwd",model.ManagerPwd)

            };
            strSql = new StringBuilder("");
            strSql.Append("select ManagerId from UserManager where ManagerName=@name and ManagerPwd=@pwd");
            id = Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString(), parameters));
            strSql = new StringBuilder("");
            strSql.Append("select ManagerType From UserManager where ManagerName=@name and ManagerPwd=@pwd");
            type = Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString(), parameters));
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

    }
    public partial class UserManagerType : SJD.IDal.IUserManagerType
    {

    }
    public partial class Recruit : SJD.IDal.IRecruit
    {

    }
}
