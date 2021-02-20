using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Loans
{
    public class LoanType
    {
        public string CarLoan { get; set; }
        public string Housing { get; set; }
        public string Cash { get; set; }

        //Navigation Property

        public  Loan Loan { get; set; }





    }
}
