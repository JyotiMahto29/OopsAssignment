using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAssignment
{
    //Create methods for all access modifier in encapsulation.
    class Bank
    {
        public long AccountNumber;
        public string Name;
        public int Balance;
        public void GetBalance()
        {
            Console.WriteLine("Public..");
        }
        private void WithdrawAmount()
        {
            Console.WriteLine("Private..");
        }
        internal void Deposit()
        {
            Console.WriteLine("Internal..");
        }
    }

}
