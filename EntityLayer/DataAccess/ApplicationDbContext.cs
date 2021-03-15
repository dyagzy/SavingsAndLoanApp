using EntityLayer.BankProfitAndLoss;
using EntityLayer.CustomerDetails;
using EntityLayer.FixDeposit;
using EntityLayer.Loans;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DataAccess
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<CustomerProfile> CustomerProfiles { get; set; }
        public DbSet<FixedDeposit> FixedDeposits { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Tenor> Tenors { get; set; }
        public DbSet<PaymentRecord> PaymentRecords { get; set; }
        public DbSet<DebitCardIssuance> debitCardIssuances { get; set; }
        public DbSet<RoundUpSaving> RoundUpSavings { get; set; }
        public DbSet<CashDeposit> CashDeposits { get; set; }
        public DbSet<SavingsAccount> SavingsAccounts { get; set; }
        public DbSet<DomCustomer> DomCustomers { get; set; }
        public DbSet<TransactionHistory> TransactionHistories { get; set; }


    }
}
