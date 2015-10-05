using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_transactions
{
    class CheckingAccount:Account
    {
        private double overDraw = -400;
        public CheckingAccount(string idNum, double bal)
            : base(idNum, bal)
        {

        }
        public override void withdraw(double amount)
        {
            if ((base.Balance - amount) >= overDraw)
                base.Balance -= amount;
            else
                Console.WriteLine("insuficient balance in Your Account");
        }
    }
}
