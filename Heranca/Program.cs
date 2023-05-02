using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UpCasting
            Account acc1 = bacc;

            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1003, "Bob", 0.0, 200.0);

            //DownCasting
            BusinessAccount acc4 = (BusinessAccount)acc2;
        }
    }
}