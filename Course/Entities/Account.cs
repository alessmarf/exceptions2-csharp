using System;


namespace Course.Entities.Exceptions
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithLimit { get; set; }

        public Account(int number, string holder, double balance, double withLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithLimit = withLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void WithDraw(double amount)
        {
            if(Balance <= amount)
            {
                throw new DomainException("Not enough balance");
            }
            else if (WithLimit >= amount)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            Balance -= amount;
        }

    }
}
