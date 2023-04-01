using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Instances
    {
        private static DemkaEntities _db;

        public static DemkaEntities db
        {
            get
            {
                if (_db == null) ;
                _db = new DemkaEntities();
                return _db;
            }
        }
    }
}
