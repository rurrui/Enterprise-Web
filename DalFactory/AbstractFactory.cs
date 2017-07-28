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
    }
}
