﻿// <auto-generated />
using System;
using EntityLayer.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BankCreditCustomerProfile", b =>
                {
                    b.Property<int>("BankCreditsId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerProfilesId")
                        .HasColumnType("int");

                    b.HasKey("BankCreditsId", "CustomerProfilesId");

                    b.HasIndex("CustomerProfilesId");

                    b.ToTable("BankCreditCustomerProfile");
                });

            modelBuilder.Entity("BankDebitCustomerProfile", b =>
                {
                    b.Property<int>("BankDebitsId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerProfilesId")
                        .HasColumnType("int");

                    b.HasKey("BankDebitsId", "CustomerProfilesId");

                    b.HasIndex("CustomerProfilesId");

                    b.ToTable("BankDebitCustomerProfile");
                });

            modelBuilder.Entity("CashDepositCustomerProfile", b =>
                {
                    b.Property<int>("CashDepositsId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerProfilesId")
                        .HasColumnType("int");

                    b.HasKey("CashDepositsId", "CustomerProfilesId");

                    b.HasIndex("CustomerProfilesId");

                    b.ToTable("CashDepositCustomerProfile");
                });

            modelBuilder.Entity("CustomerProfileDebitCardIssuance", b =>
                {
                    b.Property<int>("CustomerProfilesId")
                        .HasColumnType("int");

                    b.Property<int>("DebitCardIssuancesId")
                        .HasColumnType("int");

                    b.HasKey("CustomerProfilesId", "DebitCardIssuancesId");

                    b.HasIndex("DebitCardIssuancesId");

                    b.ToTable("CustomerProfileDebitCardIssuance");
                });

            modelBuilder.Entity("EntityLayer.BankProfitAndLoss.BankCredit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CreditAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateOfTransaction")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BankCredit");
                });

            modelBuilder.Entity("EntityLayer.BankProfitAndLoss.BankDebit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateOfTransaction")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DebitAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("BankDebit");
                });

            modelBuilder.Entity("EntityLayer.CashDeposit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumberOfRecipient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("AmountInWords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DepositDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumberOfDepositor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CashDeposits");
                });

            modelBuilder.Entity("EntityLayer.CustomerDetails.CustomerProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountHolder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressOfNextOfKin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("CustomerImage")
                        .HasColumnType("tinyint");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("NameOfNextOfKin")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherNames")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumberOfNextOfKin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Signature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("CustomerProfiles");
                });

            modelBuilder.Entity("EntityLayer.DebitCardIssuance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cvv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpiryDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("debitCardIssuances");
                });

            modelBuilder.Entity("EntityLayer.DomCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountHolder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressOfNextOfKin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currencies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("CustomerImage")
                        .HasColumnType("tinyint");

                    b.Property<int?>("CustomerProfilesId")
                        .HasColumnType("int");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("NameOfNextOfKin")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherNames")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumberOfNextOfKin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerProfilesId");

                    b.ToTable("DomCustomers");
                });

            modelBuilder.Entity("EntityLayer.FixDeposit.FixedDeposit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AmountDue")
                        .HasColumnType("decimal(18,6)");

                    b.Property<int>("CustomerProfileId")
                        .HasColumnType("int");

                    b.Property<decimal>("Interest")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("Principal")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,6)");

                    b.Property<float>("Time")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CustomerProfileId")
                        .IsUnique();

                    b.ToTable("FixedDeposits");
                });

            modelBuilder.Entity("EntityLayer.Loans.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerProfileId")
                        .HasColumnType("int");

                    b.Property<decimal>("InterestRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("InterestType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("LoanAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("NumberOfPayment")
                        .HasColumnType("int");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentRecordId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RepaymentStartDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("Tenor")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CustomerProfileId")
                        .IsUnique();

                    b.HasIndex("PaymentRecordId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("EntityLayer.Loans.LoanType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarLoan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Housing")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LoanId");

                    b.ToTable("LoanType");
                });

            modelBuilder.Entity("EntityLayer.Loans.RepayLoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ChequeBankId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChequeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoadId")
                        .HasColumnType("int");

                    b.Property<int>("LoanId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RepaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TenureTypeId")
                        .HasColumnType("int");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LoanId")
                        .IsUnique();

                    b.HasIndex("TenureTypeId");

                    b.ToTable("RepayLoan");
                });

            modelBuilder.Entity("EntityLayer.PaymentRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoadId")
                        .HasColumnType("int");

                    b.Property<string>("OtherNames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaymentRecords");
                });

            modelBuilder.Entity("EntityLayer.RoundUpSaving", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AccountCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("AccountOwnerID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerProfileId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CustomerProfileId")
                        .IsUnique();

                    b.ToTable("RoundUpSavings");
                });

            modelBuilder.Entity("EntityLayer.SavingsAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AccountCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("AccountOwnerID")
                        .HasColumnType("int");

                    b.Property<decimal>("CurrentBalance")
                        .HasColumnType("decimal(18,6)");

                    b.Property<int>("CustomerProfileId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("InitialBal")
                        .HasColumnType("decimal(18,6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CustomerProfileId")
                        .IsUnique();

                    b.ToTable("SavingsAccounts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("SavingsAccount");
                });

            modelBuilder.Entity("EntityLayer.Tenor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Days")
                        .HasColumnType("datetime2");

                    b.Property<int>("LoanId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Month")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Weeks")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LoanId");

                    b.ToTable("Tenors");
                });

            modelBuilder.Entity("EntityLayer.TenorType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Days")
                        .HasColumnType("datetime2");

                    b.Property<int>("LoanId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Month")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Weeks")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LoanId")
                        .IsUnique();

                    b.ToTable("TenorType");
                });

            modelBuilder.Entity("EntityLayer.TransactionHistory", b =>
                {
                    b.HasBaseType("EntityLayer.SavingsAccount");

                    b.Property<DateTime>("DateOfTransaction")
                        .HasColumnType("datetime2");

                    b.Property<int>("TransactionAmount")
                        .HasColumnType("int");

                    b.Property<string>("TransactionComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TransactionHistorySearchPeriod")
                        .HasColumnType("datetime2");

                    b.Property<string>("TransactionRecipientBankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionRecipientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionType")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("TransactionHistory");
                });

            modelBuilder.Entity("BankCreditCustomerProfile", b =>
                {
                    b.HasOne("EntityLayer.BankProfitAndLoss.BankCredit", null)
                        .WithMany()
                        .HasForeignKey("BankCreditsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.CustomerDetails.CustomerProfile", null)
                        .WithMany()
                        .HasForeignKey("CustomerProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BankDebitCustomerProfile", b =>
                {
                    b.HasOne("EntityLayer.BankProfitAndLoss.BankDebit", null)
                        .WithMany()
                        .HasForeignKey("BankDebitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.CustomerDetails.CustomerProfile", null)
                        .WithMany()
                        .HasForeignKey("CustomerProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CashDepositCustomerProfile", b =>
                {
                    b.HasOne("EntityLayer.CashDeposit", null)
                        .WithMany()
                        .HasForeignKey("CashDepositsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.CustomerDetails.CustomerProfile", null)
                        .WithMany()
                        .HasForeignKey("CustomerProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerProfileDebitCardIssuance", b =>
                {
                    b.HasOne("EntityLayer.CustomerDetails.CustomerProfile", null)
                        .WithMany()
                        .HasForeignKey("CustomerProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.DebitCardIssuance", null)
                        .WithMany()
                        .HasForeignKey("DebitCardIssuancesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.DomCustomer", b =>
                {
                    b.HasOne("EntityLayer.CustomerDetails.CustomerProfile", "CustomerProfiles")
                        .WithMany("DomCustomers")
                        .HasForeignKey("CustomerProfilesId");

                    b.Navigation("CustomerProfiles");
                });

            modelBuilder.Entity("EntityLayer.FixDeposit.FixedDeposit", b =>
                {
                    b.HasOne("EntityLayer.CustomerDetails.CustomerProfile", "CustomerProfiles")
                        .WithOne("FixedDeposits")
                        .HasForeignKey("EntityLayer.FixDeposit.FixedDeposit", "CustomerProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerProfiles");
                });

            modelBuilder.Entity("EntityLayer.Loans.Loan", b =>
                {
                    b.HasOne("EntityLayer.CustomerDetails.CustomerProfile", "CustomerProfile")
                        .WithOne("Loans")
                        .HasForeignKey("EntityLayer.Loans.Loan", "CustomerProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.PaymentRecord", "PaymentRecord")
                        .WithMany()
                        .HasForeignKey("PaymentRecordId");

                    b.Navigation("CustomerProfile");

                    b.Navigation("PaymentRecord");
                });

            modelBuilder.Entity("EntityLayer.Loans.LoanType", b =>
                {
                    b.HasOne("EntityLayer.Loans.Loan", "Loan")
                        .WithMany("LoanType")
                        .HasForeignKey("LoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loan");
                });

            modelBuilder.Entity("EntityLayer.Loans.RepayLoan", b =>
                {
                    b.HasOne("EntityLayer.Loans.Loan", "Loan")
                        .WithOne("RepayLoan")
                        .HasForeignKey("EntityLayer.Loans.RepayLoan", "LoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Tenor", "TenureType")
                        .WithMany()
                        .HasForeignKey("TenureTypeId");

                    b.Navigation("Loan");

                    b.Navigation("TenureType");
                });

            modelBuilder.Entity("EntityLayer.RoundUpSaving", b =>
                {
                    b.HasOne("EntityLayer.CustomerDetails.CustomerProfile", "CustomerProfiles")
                        .WithOne("RoundupSavings")
                        .HasForeignKey("EntityLayer.RoundUpSaving", "CustomerProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerProfiles");
                });

            modelBuilder.Entity("EntityLayer.SavingsAccount", b =>
                {
                    b.HasOne("EntityLayer.CustomerDetails.CustomerProfile", "Customerprofiles")
                        .WithOne("SavingsAccounts")
                        .HasForeignKey("EntityLayer.SavingsAccount", "CustomerProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customerprofiles");
                });

            modelBuilder.Entity("EntityLayer.Tenor", b =>
                {
                    b.HasOne("EntityLayer.Loans.Loan", "Loan")
                        .WithMany()
                        .HasForeignKey("LoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loan");
                });

            modelBuilder.Entity("EntityLayer.TenorType", b =>
                {
                    b.HasOne("EntityLayer.Loans.Loan", "Loan")
                        .WithOne("TenorType")
                        .HasForeignKey("EntityLayer.TenorType", "LoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loan");
                });

            modelBuilder.Entity("EntityLayer.CustomerDetails.CustomerProfile", b =>
                {
                    b.Navigation("DomCustomers");

                    b.Navigation("FixedDeposits");

                    b.Navigation("Loans");

                    b.Navigation("RoundupSavings");

                    b.Navigation("SavingsAccounts");
                });

            modelBuilder.Entity("EntityLayer.Loans.Loan", b =>
                {
                    b.Navigation("LoanType");

                    b.Navigation("RepayLoan");

                    b.Navigation("TenorType");
                });
#pragma warning restore 612, 618
        }
    }
}
