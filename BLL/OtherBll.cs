using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJD.BLL
{
    
    public partial class Picture
    {
        private readonly SJD.IDal.IPicture dal = SJD.DalFactory.AbstractFactory.GetPicture();
    }
    
}
