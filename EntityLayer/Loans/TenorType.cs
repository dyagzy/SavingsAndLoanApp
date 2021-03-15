using EntityLayer.Loans;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{

    public class TenorType

    {
        public int Id { get; set; }
        public DateTime Days { get; set; }
        public DateTime Weeks { get; set; }
        public DateTime Month { get; set; }
        public DateTime Year { get; set; }


        //Navigation Properties
        public int LoanId { get; set; }
        public Loan Loan  { get; set; }




    }
}
