namespace Course.Entities
{
    /// <summary>
    /// Herança é uma Associação entre classe e não entre objetos
    /// </summary>
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string hilder, double balance,double loanLimit) : base (number,hilder,balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
