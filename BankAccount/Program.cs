using System.Security.Principal;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instansiera bankAccount klassen och testa den
            BankAccount myBankAccount = new BankAccount("45674566", "Ricky", 5000);

            myBankAccount.Deposit(500);
            myBankAccount.Withdraw(1000);
            myBankAccount.getInfo();

        }
    }
}
