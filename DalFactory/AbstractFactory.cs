using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SJD.DalFactory
{
    public partial class AbstractFactory
    {

        public static SJD.IDal.IPicture GetPicture()
        {
            //获取web.config中的DAL配置文件
            string temp = System.Configuration.ConfigurationManager.AppSettings["PictureDal"];
            string[] temp2 = temp.Split(',');

            //反射：创建对象

            //1.0 获取程序集对象
            Assembly asm = Assembly.Load(temp2[1]);// 程序集名称
            //2.0 创建实例
            Object obj = asm.CreateInstance(temp2[0]);//类的完整名称
            return obj as SJD.IDal.IPicture;
        }
        public static SJD.IDal.INews GetNews()
        {
            string temp = System.Configuration.ConfigurationManager.AppSettings["NewsDal"];
            string[] temp2 = temp.Split(',');
            Assembly asm = Assembly.Load(temp2[1]);
            Object obj = asm.CreateInstance(temp2[0]);
            return obj as SJD.IDal.INews;
        }
        public static SJD.IDal.IProduction GetProduction()
        {
            string temp = System.Configuration.ConfigurationManager.AppSettings["ProductionDal"];
            string[] temp2 = temp.Split(',');
            Assembly asm = Assembly.Load(temp2[1]);
            Object obj = asm.CreateInstance(temp2[0]);
            return obj as SJD.IDal.IProduction;
        }
        public static SJD.IDal.ISolution GetSolution()
        {
            string temp = System.Configuration.ConfigurationManager.AppSettings["SolutionDal"];
            string[] temp2 = temp.Split(',');
            Assembly asm = Assembly.Load(temp2[1]);
            Object obj = asm.CreateInstance(temp2[0]);
            return obj as SJD.IDal.ISolution;
        }
        public static SJD.IDal.IUserManager GetUserManager()
        {
            string temp = System.Configuration.ConfigurationManager.AppSettings["ManagerDal"];
            string[] temp2 = temp.Split(',');
            Assembly asm = Assembly.Load(temp2[1]);
            Object obj = asm.CreateInstance(temp2[0]);
            return obj as SJD.IDal.IUserManager;
        }
        public static SJD.IDal.IUserManagerType GetUserManagerType()
        {
            string temp = System.Configuration.ConfigurationManager.AppSettings["ManagerTypeDal"];
            string[] temp2 = temp.Split(',');
            Assembly asm = Assembly.Load(temp2[1]);
            Object obj = asm.CreateInstance(temp2[0]);
            return obj as SJD.IDal.IUserManagerType;
        }
    }
}
