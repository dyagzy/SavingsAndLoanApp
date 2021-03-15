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
        


        //Navigation properties

        public int LoadId { get; set; }
       // public Loan Loan { get; set; }



    }
}
