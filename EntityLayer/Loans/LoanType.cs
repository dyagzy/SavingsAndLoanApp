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

<<<<<<< HEAD
        //Navigation Property

        public  Loan Loan { get; set; }





=======
>>>>>>> 990fe90084514b7631032ab0f149a0dfd896ba32
    }
}
