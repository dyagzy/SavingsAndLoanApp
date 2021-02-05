using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class SavingsInterestCalculator
    {
        public decimal Interest(int InterestRate, decimal AvailableBalance)
        {
            var interestToReturn = ((decimal)InterestRate) / 100 * AvailableBalance;
            return interestToReturn;
        }
    }
}
