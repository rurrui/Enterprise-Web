using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJD.IDal
{
    public partial interface IProduction
    {
        int GetMaxId();
        bool Exists(int ProId);
        int Add(SJD.Model.Production model);
        bool Update(SJD.Model.Production model);
        bool Delete(int ProId);
        bool DeleteList(string ProIdlist);
        SJD.Model.Production GetModel(int ProId);
        SJD.Model.Production DataRowToModel(DataRow row);
        DataSet GetList(string strWhere);
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);

    }
}
