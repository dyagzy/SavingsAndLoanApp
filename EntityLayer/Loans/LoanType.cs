using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Loans
{
    public class LoanType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public string CarLoan { get; set; }
        public string Housing { get; set; }
        public string Cash { get; set; }

        // Navigation propery

        public int LoanId { get; set; }
        public  Loan Loan { get; set; }
        public LoanCustomer LoanCustomer { get; set; }

    }
}
