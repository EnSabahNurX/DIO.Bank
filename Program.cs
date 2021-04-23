using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {
        static List<Account> listAccount = new List<Account>();
        static void Main(string[] args)
        {
            // Account myAccount = new Account(AccountType.Natural, 0, 0, "Ricardo");
            // Console.WriteLine(myAccount.ToString());
            string userOpt = GetUserOpt();
            while (userOpt.ToUpper() != "X")
            {
                switch (userOpt)
                {
                    case "1":
                        // ListAccounts();
                        break;
                    case "2":
                        AddConta();
                        break;
                    case "3":
                        // Transfer();
                        break;
                    case "4":
                        // Withdraw();
                        break;
                    case "5":
                        // Deposit();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                userOpt = GetUserOpt();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static string GetUserOpt()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank at your service!!!");
            Console.WriteLine("Please, select your option by pressing the number in the list:");

            Console.WriteLine("1- Show all accounts");
            Console.WriteLine("2- Add a new account");
            Console.WriteLine("3- Transfer");
            Console.WriteLine("4- Withdraw");
            Console.WriteLine("5- Deposit");
            Console.WriteLine("C- Clean the screen");
            Console.WriteLine("X- Exit, See you soon!");
            Console.WriteLine();

            string userOpt = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOpt;
        }
        private static void AddConta()
        {
            Console.WriteLine("Add a new account");

            Console.Write("Type \"1\" to natural personal account and \"2\" to company account: ");
            int accountTypeEntry = int.Parse(Console.ReadLine());

            Console.Write("Type the customer name: ");
            string nameEntry = Console.ReadLine();

            Console.Write("Type the initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine());

            Console.Write("Type the credit limit: ");
            double creditEntry = double.Parse(Console.ReadLine());

            Account novaConta = new Account(accountType: (AccountType)accountTypeEntry,
                                        balance: initialBalance,
                                        credit: creditEntry,
                                        name: nameEntry);

            // listContas.Add(novaConta);
        }

    }
}
