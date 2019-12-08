using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    internal class MyDal : IDal
    {
        public bool AddHost(Host host)
        {
            foreach (var item in DataSource.Hosts)
            {
                if(item.HostKey==host.HostKey)
                {
                    return false;
                }
            }
            DataSource.Hosts.Add(host);
            return true;
        }

        public bool RemoveHost(Host host)
        {
            Host killed = null;
            foreach (var item in DataSource.Hosts)
            {
                if (item.HostKey == host.HostKey)
                {
                   killed = item;
                   break;
                }
            }
            //if(killed == null)
            //{
            //    return false;
            //}
            return DataSource.Hosts.Remove(killed);
        }
    }
}
