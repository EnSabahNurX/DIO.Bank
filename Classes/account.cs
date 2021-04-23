using System;

namespace DIO.Bank
{
    public class Account
    {
        // Attributes
        private AccountType AccountType { get; set; }
        private double Balance { get; set; }
        private double Credit { get; set; }
        private string Name { get; set; }
        // Methods
        public Account(AccountType accountType, double balance, double credit, string name)
        {
            this.AccountType = accountType;
            this.Balance = balance;
            this.Credit = credit;
            this.Name = name;
        }
        public bool Sacar(double valorSaque)
        {
            // Validating balance
            if (this.Balance - valorSaque < (this.Credit * -1))
            {
                Console.WriteLine("Insuficient Balance!");
                return false;
            }
            this.Balance -= valorSaque;
            Console.WriteLine("The current balance of {0} is {1}", this.Name, this.Balance);
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Balance += valorDeposito;
            Console.WriteLine("The current balance of {0} is {1}", this.Name, this.Balance);
        }
        public void Transferir(double valorTransferencia, Account contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }
        public override string ToString()
        {
            string display = "";
            display += "AccountType " + this.AccountType + " | ";
            display += "Name " + this.Name + " | ";
            display += "Balance " + this.Balance + " | ";
            display += "Credit " + this.Credit;
            return display;
        }
    }
}