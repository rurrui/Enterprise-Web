using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJD.IDal
{
     public partial interface IPicture
    {
        int GetMaxId();
        bool Exists(int PicId);
        int Add(SJD.Model.Picture model);
        bool Update(SJD.Model.Picture model);
        bool Delete(int PicId);
        bool DeleteList(string PicIdlist);
        SJD.Model.Picture GetModel(int PicId);
        SJD.Model.Picture DataRowToModel(DataRow row);
        DataSet GetList(string strWhere);
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);

    }
}
