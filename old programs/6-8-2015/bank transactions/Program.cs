using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_transactions
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount ch = new CheckingAccount("103", 500);
            Console.WriteLine("enter how much amount to deposit?");
            double dep = double.Parse(Console.ReadLine());
            Console.WriteLine("enter how much amount to Withdraw?");
            double withdraw = double.Parse(Console.ReadLine());
            ch.deposit(dep);
            ch.withdraw(withdraw);
            Console.WriteLine("Main Balnce:"+ch.ToString());
            Console.ReadKey();
        }
    }
}
