using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {

        //Lägg till Egenskaper (fields)

        public string AccountNumber;
        public string AccountHolder;
        public int Balance;

        //Lägg till Konstruktor

        public BankAccount(string accountNumber, string accountHolder, int balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
            Console.WriteLine($"Account number:{accountNumber} \nAccount holder:{accountHolder} \nBalance:{balance}");

        }
        //Lägg till Metoder

        public void Deposit(int deposit)
        {
            Balance += deposit;
            Console.WriteLine("Deposited:" + deposit + " New Balance:" + Balance);

        }

        public void Withdraw(int withdraw)
        {
            Balance -= withdraw;
            if (Balance > withdraw)
            {
                Console.WriteLine("Withdrew:" + withdraw + " New Balance:" + Balance);
            }
            else
            {
                Console.WriteLine("Not enough money on the account");
            }
        }

        public void getInfo()
        {
            Console.WriteLine("Balance:" + Balance);
        }

        //Lycka till! :)

    }
}
