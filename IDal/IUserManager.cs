using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJD.IDal
{
    public partial interface IUserManager
    {
        int GetMaxId();
        bool Exists(int ManagerId);
        int Add(SJD.Model.UserManager model);
        bool Update(SJD.Model.UserManager model);
        bool Delete(int ManagerId);
        bool DeleteList(string ManagerIdlist);
        SJD.Model.UserManager GetModel(int ManagerId);
        SJD.Model.UserManager DataRowToModel(DataRow row);
        DataSet GetList(string strWhere);
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
        DataSet GetUnionList();
    }
}
