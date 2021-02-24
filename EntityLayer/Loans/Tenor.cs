using EntityLayer.Loans;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{

    public class Tenor

    {
        public int Id { get; set; }
        public DateTime Days { get; set; }
        public DateTime Weeks { get; set; }
        public DateTime Month { get; set; }
        public DateTime Year { get; set; }


        //Navigation properties

        public Loan Loan { get; set; }
        public int LoanId { get; set; }

    }
}
