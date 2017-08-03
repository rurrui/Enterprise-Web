using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJD.IDal
{
     public partial interface IUserManagerType
    {
        int GetMaxId();
        bool Exists(int TypeId);
        int Add(SJD.Model.UserManagerType model);
        bool Update(SJD.Model.UserManagerType model);
        bool Delete(int TypeId);
        bool DeleteList(string TypeIdlist);
        SJD.Model.UserManagerType GetModel(int TypeId);
        SJD.Model.UserManagerType DataRowToModel(DataRow row);
        DataSet GetList(string strWhere);
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
    }
}
