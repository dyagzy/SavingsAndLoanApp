using EntityLayer.AdminDetails;

using EntityLayer.BankProfitAndLoss;
using EntityLayer.CustomerDetails;
using EntityLayer.FixDeposit;
using EntityLayer.Loans;
using EntityLayer.Transaction;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DataAccess
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* The foolowing fleutn Api configuration helps to specify a ON DELETE CASCADE nehavior in the entities below where
              it was cofigured on*/

            //builder.Entity<DepositMoney>()
            //    .HasIndex(d => d.SavingsAccountId)
            //    .IsUnique(false);


            //configure the composite key for the many -to- many table DepositMoneyWithdrswMoney
            builder.Entity<DepositWithdraw>()
                .HasKey(dw => new {dw.WithdrawMoneyId, dw.DepositMoneyId });



            builder.Entity<Loan>()
                .HasOne(l => l.ApproveLoan)
                .WithOne(l => l.Loan)
                .OnDelete(DeleteBehavior.ClientCascade);


            builder.Entity<RepayLoan>()
                .HasOne(r => r.Loan)
                .WithOne(r => r.RepayLoan)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.Entity<ApproveLoan>()
                .HasOne(a => a.LoanType)
                .WithOne(a => a.ApproveLoan)
                .OnDelete(DeleteBehavior.ClientCascade);

            //builder.Entity<DepositMoney>()
            //     .HasKey(d => d.SavingsAccountId);

            //builder.Entity<DepositMoney>()
            //    .HasOne(d => d.SavingsAccount)
            //    .WithOne(d => d.DepositMoney)
            //    .OnDelete(DeleteBehavior.ClientCascade);

            //builder.Entity<SavingsAccount>();



               
              

               
                



        }

        public DbSet<CustomerProfile> CustomerProfiles { get; set; }
        public DbSet<FixedDeposit> FixedDeposits { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Tenor> Tenors { get; set; }
        public DbSet<PaymentRecord> PaymentRecords { get; set; }
        public DbSet<DebitCardIssuance> DebitCardIssuances { get; set; }
        public DbSet<RoundUpSaving> RoundUpSavings { get; set; }
        public DbSet<CashDeposit> CashDeposits { get; set; }
        public DbSet<SavingsAccount> SavingsAccounts { get; set; }
        public DbSet<DomCustomer> DomCustomers { get; set; }
        public DbSet<ApproveLoan> ApproveLoan { get; set; }
        public DbSet<RepayLoan> RepayLoans { get; set; }
        public DbSet<TransactionHistory> TransactionHistories { get; set; }
        public DbSet<DepositMoney> DepositMonies { get; set; }
        public DbSet<WithdrawMoney> WithdrawMoney { get; set; }
        public DbSet<DepositWithdraw> DepositWithdraws { get; set; }
        public DbSet <Admin> Admins { get; set; }


    }
}
