  using EntityLayer.BankProfitAndLoss;
using EntityLayer.FixDeposit;
using EntityLayer.Loans;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.CustomerDetails
{
    public class CustomerProfile
    {
        public int Id { get; set; }
        public byte CustomerImage { get; set; }
       
        //        public Guid CustomerUniqueIdentity { get; set; }
        
        public string SurName { get; set; }

        public string FirstName { get; set; }
        public string OtherNames { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }

        public string AccountType { get; set; }
        //A drop down is created here with the various account options (Savings, Loan, Wallet account, & dom account)
        public string AccountHolder { get; set; }
        //A drop down is created for account holder options(individual, cooperate or student)

        public string NameOfNextOfKin { get; set; }

        public string PhoneNumberOfNextOfKin { get; set; }
        public string AddressOfNextOfKin { get; set; }
        public string Signature { get; set; }


        /// <summary>
        /// Navigation property
        /// </summary>

        //Navigation Properties
        public SavingsAccount SavingsAccounts { get; set; }
        public Loan Loans { get; set; }
        public IEnumerable <DomCustomer> DomCustomers { get; set; }
        public  FixedDeposit FixedDeposits { get; set; }
        public IEnumerable <BankDebit> BankDebits { get; set; }
       
        public RoundUpSaving RoundupSavings { get; set; } 
 
        public IEnumerable<BankCredit> BankCredits { get; set; }
        public IEnumerable<DebitCardIssuance> DebitCardIssuances { get; set; }
        public IEnumerable<CashDeposit> CashDeposits { get; set; }

        // Repayloan can be done by a Customer while a 
        //public int RepayLoanId { get; set; }
        //public RepayLoan RepayLoan { get; set; }

        //[ForeignKey("ApproveLoanId")]
        //public ApproveLoan ApproveLoan { get; set; }


    }
}
