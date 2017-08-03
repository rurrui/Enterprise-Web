using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJD.IDal
{
    public partial interface ISolution
    {
        int GetMaxId();
        bool Exists(int SolutionId);
        int Add(SJD.Model.Solution model);
        bool Update(SJD.Model.Solution model);
        bool Delete(int SolutionId);
        bool DeleteList(string SolutionIdlist);
        SJD.Model.Solution GetModel(int SolutionId);
        SJD.Model.Solution DataRowToModel(DataRow row);
        DataSet GetList(string strWhere);
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);

    }
}
