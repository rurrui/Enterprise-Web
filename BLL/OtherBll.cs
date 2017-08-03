using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJD.BLL
{

    public partial class Picture
    {
        private readonly SJD.IDal.IPicture dal = SJD.DalFactory.AbstractFactory.GetPicture();
    }
    public partial class News
    {
        private readonly SJD.IDal.INews dal = SJD.DalFactory.AbstractFactory.GetNews();
    }
    public partial class Production
    {
        private readonly SJD.IDal.IProduction dal = SJD.DalFactory.AbstractFactory.GetProduction();
    }
    public partial class Solution
    {
        private readonly SJD.IDal.ISolution dal = SJD.DalFactory.AbstractFactory.GetSolution();
    }
    public partial class UserManager
    {
        private readonly SJD.IDal.IUserManager dal = SJD.DalFactory.AbstractFactory.GetUserManager();
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetUnionList()
        {
            return dal.GetUnionList();
        }
    }
    public partial class UserManagerType
    {
        private readonly SJD.IDal.IUserManagerType dal = SJD.DalFactory.AbstractFactory.GetUserManagerType();
      
    }
}
