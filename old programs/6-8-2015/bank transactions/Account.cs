using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_transactions
{
    class Account
    {
        private string id;
        private double balance;
        public Account()
        {
            id = "";
            balance = 0;
        }
        public Account(string idNum,double bal)
        {
            id = idNum;
            balance = bal;
        }
        public  void deposit(double amount)
        {
            balance += amount;
        }
        public virtual void withdraw(double amount)
        {
            balance -= amount;
        }
        public override string ToString()
        {

            return id + ": " + balance;
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                 balance=value;
            }
        }
    }
}
