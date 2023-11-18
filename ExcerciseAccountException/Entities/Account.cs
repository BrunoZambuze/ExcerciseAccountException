using System;
using ExcerciseAccountException.Entities.Exception;
namespace ExcerciseAccountException.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithDrawLimit { get; private set; }

        //Construtores
        public Account()
        {
        }

        public Account(string holder)
        {
            if (holder.Any(char.IsDigit))
            {
                throw new DomainException("Holder must contain only letters");
            }
            Holder = holder;
        }

        public Account(int number, double limit)
        {
            Number = number;
            Balance = 0.0;
            WithDrawLimit = limit;
        }

        //Procedimento de depósito
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        //Função de saque
        public void WithDraw(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Withdraw not completed, insufficient balance");
            }
            if (Balance <= 0)
            {
                throw new DomainException("A withdraw was not made, the balance is zero");
            }
            if (amount > WithDrawLimit)
            {
                throw new DomainException("Withdraw not executed, requested amount exceeds the account's withdraw limit");
            }
            Balance -= amount;
        }

        //Imprimir
        public override string ToString()
        {
            return $"New balance: {Balance:c}";
        }
    }
}
