using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJD.IDal
{
    public partial interface IRecruit
    {
        int GetMaxId();
        bool Exists(int RecruitId);
        int Add(SJD.Model.Recruit model);
        bool Update(SJD.Model.Recruit model);
        bool Delete(int RecruitId);
        bool DeleteList(string RecruitIdlist);
        SJD.Model.Recruit GetModel(int RecruitId);
        SJD.Model.Recruit DataRowToModel(DataRow row);
        DataSet GetList(string strWhere);
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);

    }
}
