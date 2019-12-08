using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   internal class DataSource
    {
        private static List<Host> myhosts = new List<Host>();

        public static List<Host> Hosts { get => myhosts; }
    }
}
