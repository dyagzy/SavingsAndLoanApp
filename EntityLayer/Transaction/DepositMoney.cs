using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Transaction
{
    public class DepositMoney
    {
        SavingsAccount account = new SavingsAccount();

        [Key]
        public int Id { get; set; }
        
        public decimal Amount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string NameofDepositor
        {
            get
            {
                //char convertName = FirstName[0].ToUpper();
                return FirstName.ToUpper() + " " + LastName;
            }
        }
        public decimal CurrentBalance { get; set; }
        public string AccountHolder => account.FullName;
       
        public DateTime DepositDate { get; set; }
        public string PhoneOfDepositor { get; set; }

        //Navigation  property
        public int SavingsAccountId { get; set; }
        public SavingsAccount SavingsAccount { get; set; }

        //public IEnumerable<WithdrawMoney> WithdrawMoney { get; set; }
        public WithdrawMoney WithdrawMoney { get; set; }

       // public IEnumerable<TransactionHistory> TransactionHistories { get; set; }




    }
}
