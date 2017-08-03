using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJD.IDal
{
    public partial interface INews
    {
        int GetMaxId();
        bool Exists(int NewId);
        int Add(SJD.Model.News model);
        bool Update(SJD.Model.News model);
        bool Delete(int NewId);
        bool DeleteList(string NewIdlist);
        SJD.Model.News GetModel(int NewId);
        SJD.Model.News DataRowToModel(DataRow row);
        DataSet GetList(string strWhere);
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);

    }
}
