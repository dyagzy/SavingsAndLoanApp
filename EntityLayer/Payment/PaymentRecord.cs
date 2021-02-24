using EntityLayer.Loans;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class PaymentRecord
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }
        public string OtherNames { get; set; }
        // public int MyProperty { get; set; }


        //Navigation properties
<<<<<<< HEAD
        public int LoadId { get; set; }
        public Loan Loan { get; set; }
=======
        public Loan Loan { get; set; }
        public int LoanId { get; set; }
>>>>>>> 990fe90084514b7631032ab0f149a0dfd896ba32


    }
}
