using BankAccount.Entities.Exceptions;

namespace BankAccount.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (withdrawLimit <= 0)
            {
                throw new DomainException("Withdraw limit must be greater than zero");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new DomainException("Amount for deposit can't be negative");
            }

            Balance += amount;
        }

        public void Witdhdraw (double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (amount < 0)
            {
                throw new DomainException("Amount for withdraw can't be negative");
            }

            Balance -= amount;
        }
    }
}
