using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbankPracticumHGS.Core
{
    public class TransactionDisplay
    {
        public DateTime DateTime { get; set; }  
        public string HGSno { get; set; }
   
        public string Name { get; set; }
        public string Surname { get; set; }   
        public string Type { get; set; }

        public int Payment { get; set; }
        public int Balance { get; set; }
    
    }
}
