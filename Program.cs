using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account(AccountType.Natural, 0, 0, "Ricardo");
            Console.WriteLine(myAccount.ToString());
        }
    }
}
