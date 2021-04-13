using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Loans
{
    public class ApproveLoan
    {
       // private CustomerProfile name;
       //private bool _isApproved;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public LoanType Name { get; set; }
        public decimal LoanValue { get; set; }
        public DateTime ApprovalDate { get; set; }
        public bool IsApprove 
        {
            set
            {
                IsApproveLoan();
            }
        }

        public string FullName
        {
            get
            {
                return FirstName + "  " + LastName;
            }
        }

        //Navigational Properties

        public SavingsAccount SavingsAccount { get; set; }
        public Loan Loan { get; set; }
        public int LoanTypeId { get; set; }
        public LoanType LoanType { get; set; }
        public int CustomerProfileId { get; set; }
        public CustomerProfile CustomerProfile { get; set; }




        //utility methods

        public bool IsApproveLoan()
        {
            CustomerProfile customer = new CustomerProfile();
            bool isApproved = false;
            //if (customer.SavingsAccounts.IsActive)
            //{
            //    isApproved = true;
            //}
            return isApproved;
        }
    }
}
