using AkbankPracticumHGS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbankPracticumHGS.Process
{
    public class Gise
    {
        // vehicle transactions list
        List<TransactionDisplay> transactions = new List<TransactionDisplay>();

 

        // payment accept function
        public List<TransactionDisplay> VehiclePass(BaseVehicle bvehicle)
        {
            // balance calculates according to vehicle type
            bvehicle.Balance = bvehicle.Balance - bvehicle.Price();


            TransactionDisplay t = new TransactionDisplay();
            t.DateTime = DateTime.Now;
            t.HGSno = bvehicle.HGSno;
            t.Name = bvehicle.Name;
            t.Surname = bvehicle.Surname;
            t.Type = bvehicle.Type;
            t.Payment = bvehicle.Price();
            t.Balance = bvehicle.Balance;
            transactions.Add(t);    
            return transactions;  
        }




    }
}
