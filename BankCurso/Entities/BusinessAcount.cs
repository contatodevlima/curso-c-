using System;
using System.Collections.Generic;
using System.Text;

namespace BankCurso.Entities
{
    class BusinessAcount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAcount()
        {
        }

        public BusinessAcount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double loan)
        {
            if (loan <= LoanLimit)
            {
                Balance += loan;
            }
        }
    }
}
