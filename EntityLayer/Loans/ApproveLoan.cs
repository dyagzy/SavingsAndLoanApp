using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Loans
{
    public class ApproveLoan
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;

            }
        }

        //nAV

        public SavingsAccount SavingsAccount { get; set; }
        public Loan Loan { get; set; }
    }
}
