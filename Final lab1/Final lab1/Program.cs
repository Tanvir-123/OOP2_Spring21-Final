using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            Account a1 = new Account("Gabi", "101", 5000f);
            Account a2 = new Account("Falco", "102", 3000f);
            Account a3 = new Account("Reiner", "103", 1500f);

            a1.ShowInfo();
            a2.ShowInfo();
            a3.ShowInfo();

            a1.Deposit(500);
            a2.Withdraw(500);
            a3.Transfer(a2, 1000);
            a3.Deposit(500);
            a1.Withdraw(1500);
            a1.Transfer(a3, 500);
            a2.Deposit(500);


            a1.showAllTransaction();
            a2.showAllTransaction();
            a3.showAllTransaction();


        }
    }
}