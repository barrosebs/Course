namespace Course.Entities
{
    class Account
    {
        public int Namber { get; private set; }
        public string Hilder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int namber, string hilder, double balance)
        {
            Namber = namber;
            Hilder = hilder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}
