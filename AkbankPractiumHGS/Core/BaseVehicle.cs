using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbankPracticumHGS.Core
{
    public abstract class BaseVehicle
    {

        public string HGSno { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Balance { get; set; }
        public string Type { get; set; }
        public abstract int Price();
    }
}
