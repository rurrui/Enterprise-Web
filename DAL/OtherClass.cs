using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
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

    }
    public partial class UserManagerType : SJD.IDal.IUserManagerType
    {

    }
}
