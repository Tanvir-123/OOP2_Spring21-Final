using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_lab1
{
    public class Account
    {
        public string AccID { get; set; }
        public string AccName { get; set; }
        public double Balance { get; set; }

        Transaction[] transactions = new Transaction[20];
        public int transactionCount { get; set; }

        public Account() { }
        public Account(string accName, string accId, double accBalance)
        {
            AccID = accId;
            AccName = accName;
            Balance = accBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("{0} 's account is deposited by {1}. Current balance: {2}", this.AccName, amount, Balance);
            transactions[transactionCount++] = new Transaction(this, this, amount, "Self deposited");
        }

        public void Withdraw(double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                Console.WriteLine("{0} 's account is withdrawn by {1}. Current balance: {2}", this.AccName, amount, Balance);
                transactions[transactionCount++] = new Transaction(this, this, amount, "Self withdrawn");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public void Transfer(Account acc, double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                acc.Balance += amount;
                Console.WriteLine("{1}'s account transferred amount {0} to the {2}'s account. Current balance : {3} ", amount, this.AccName, acc.AccName, Balance);
                transactions[transactionCount++] = new Transaction(this, acc, amount, "Transfered");

            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }


        public void ShowInfo()
        {
            Console.WriteLine(" Account Name: " + AccName);
            Console.WriteLine(" Account ID: " + AccID);
            Console.WriteLine(" Current Balance: " + Balance);
            Console.WriteLine();
        }



        public void showAllTransaction()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("<< Transaction history of {0} >>", this.AccName);

            for (int i = 0; i < transactionCount; i++)
            {
                transactions[i].showTransactions();
            }
        }

    }
}