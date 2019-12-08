using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class FactorySingletonDal
    {
        private static IDal instance = null;

        public static IDal GetInstance
        {
            get
            {
                if(instance == null)
                {
                    instance = new MyDal();
                }
                return instance;
            }
        }
    }
}
