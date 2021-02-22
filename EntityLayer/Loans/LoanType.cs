using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Loans
{
    public class LoanType
    {
        public int Id { get; set; }
        public string CarLoan { get; set; }
        public string Housing { get; set; }
        public string Cash { get; set; }
        /// <summary>
        /// Navigation propery
        /// </summary>
        /// 
        public Loan Loans { get; set; }
        public int LoanId { get; set; }

    }
}
