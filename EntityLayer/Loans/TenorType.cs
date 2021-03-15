using EntityLayer.Loans;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
<<<<<<< HEAD:EntityLayer/Loans/TenorType.cs
    public class TenorType
=======
    public class Tenor
>>>>>>> 990fe90084514b7631032ab0f149a0dfd896ba32:EntityLayer/Loans/Tenor.cs
    {
        public int Id { get; set; }
        public DateTime Days { get; set; }
        public DateTime Weeks { get; set; }
        public DateTime Month { get; set; }
        public DateTime Year { get; set; }

<<<<<<< HEAD:EntityLayer/Loans/TenorType.cs
        //Navigation Properties
        public int LoanId { get; set; }
        public Loan Loan  { get; set; }



=======
        //Navigation properties

        public Loan Loan { get; set; }
        public int LoanId { get; set; }
>>>>>>> 990fe90084514b7631032ab0f149a0dfd896ba32:EntityLayer/Loans/Tenor.cs
    }
}
