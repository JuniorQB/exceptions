using TratamentoExcecao.Entities.Exepetions;

namespace TratamentoExcecao.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }


        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }


        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {

                throw new DomainExeption("Withdrawal amount greater than allowed");
            }

            if (amount >= Balance)
            {
                throw new DomainExeption("Error: no account balance");
            }

          

            Balance -= amount;

        }

        public override string ToString()
        {
            return "New balance: "+Balance;
        }
    }
}
