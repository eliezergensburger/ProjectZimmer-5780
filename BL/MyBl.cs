using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    public class MyBl
    {
        public bool InsertHost(Host host)
        {
            //add some logic here
            FactorySingletonDal.GetInstance.AddHost(host);
            return true;
        }
    }
}
