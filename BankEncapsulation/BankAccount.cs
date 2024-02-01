using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private  double _balance = 0;

        public void Deposit(double amountDeposited)
        {
            Console.WriteLine($"Deposit of {amountDeposited,0:c} to your account.");
            _balance += amountDeposited;
        }
        public double GetBalance() 
        {
            return _balance;
        }
    }
}
