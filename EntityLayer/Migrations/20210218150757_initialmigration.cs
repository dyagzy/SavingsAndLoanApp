using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityLayer.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankCredits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankCreditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateOfTransaction = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankCredits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankDebits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankDebitAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateOfTransaction = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankDebits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CashDeposits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountNumberOfRecipient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepositDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumberOfDepositor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountInWords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashDeposits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerImage = table.Column<byte>(type: "tinyint", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    OtherNames = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountHolder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameOfNextOfKin = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    PhoneNumberOfNextOfKin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressOfNextOfKin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Signature = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "debitCardIssuances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cvv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debitCardIssuances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FixedDeposits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Principal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Time = table.Column<float>(type: "real", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountDue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interest = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixedDeposits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenor = table.Column<float>(type: "real", nullable: false),
                    NumberOfPayment = table.Column<int>(type: "int", nullable: false),
                    InterestRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InterestType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepaymentStartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SavingsAccounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AccountCreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AccountOwnerID = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionHistorySearchPeriod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfTransaction = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TransactionAmount = table.Column<int>(type: "int", nullable: true),
                    TransactionRecipientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionRecipientBankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingsAccounts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BankCreditCustomerProfile",
                columns: table => new
                {
                    BankCreditsId = table.Column<int>(type: "int", nullable: false),
                    CustomerProfilesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankCreditCustomerProfile", x => new { x.BankCreditsId, x.CustomerProfilesId });
                    table.ForeignKey(
                        name: "FK_BankCreditCustomerProfile_BankCredits_BankCreditsId",
                        column: x => x.BankCreditsId,
                        principalTable: "BankCredits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankCreditCustomerProfile_CustomerProfiles_CustomerProfilesId",
                        column: x => x.CustomerProfilesId,
                        principalTable: "CustomerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankDebitCustomerProfile",
                columns: table => new
                {
                    BankDebitsId = table.Column<int>(type: "int", nullable: false),
                    CustomerProfilesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankDebitCustomerProfile", x => new { x.BankDebitsId, x.CustomerProfilesId });
                    table.ForeignKey(
                        name: "FK_BankDebitCustomerProfile_BankDebits_BankDebitsId",
                        column: x => x.BankDebitsId,
                        principalTable: "BankDebits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankDebitCustomerProfile_CustomerProfiles_CustomerProfilesId",
                        column: x => x.CustomerProfilesId,
                        principalTable: "CustomerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CashDepositCustomerProfile",
                columns: table => new
                {
                    CashDepositsId = table.Column<int>(type: "int", nullable: false),
                    CustomerProfilesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashDepositCustomerProfile", x => new { x.CashDepositsId, x.CustomerProfilesId });
                    table.ForeignKey(
                        name: "FK_CashDepositCustomerProfile_CashDeposits_CashDepositsId",
                        column: x => x.CashDepositsId,
                        principalTable: "CashDeposits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CashDepositCustomerProfile_CustomerProfiles_CustomerProfilesId",
                        column: x => x.CustomerProfilesId,
                        principalTable: "CustomerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DomCustomers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerImage = table.Column<byte>(type: "tinyint", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    OtherNames = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountHolder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameOfNextOfKin = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    PhoneNumberOfNextOfKin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressOfNextOfKin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currencies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerProfilesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomCustomers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DomCustomers_CustomerProfiles_CustomerProfilesId",
                        column: x => x.CustomerProfilesId,
                        principalTable: "CustomerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerProfileDebitCardIssuance",
                columns: table => new
                {
                    CustomerProfilesId = table.Column<int>(type: "int", nullable: false),
                    DebitCardIssuancesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProfileDebitCardIssuance", x => new { x.CustomerProfilesId, x.DebitCardIssuancesId });
                    table.ForeignKey(
                        name: "FK_CustomerProfileDebitCardIssuance_CustomerProfiles_CustomerProfilesId",
                        column: x => x.CustomerProfilesId,
                        principalTable: "CustomerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerProfileDebitCardIssuance_debitCardIssuances_DebitCardIssuancesId",
                        column: x => x.DebitCardIssuancesId,
                        principalTable: "debitCardIssuances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankCreditCustomerProfile_CustomerProfilesId",
                table: "BankCreditCustomerProfile",
                column: "CustomerProfilesId");

            migrationBuilder.CreateIndex(
                name: "IX_BankDebitCustomerProfile_CustomerProfilesId",
                table: "BankDebitCustomerProfile",
                column: "CustomerProfilesId");

            migrationBuilder.CreateIndex(
                name: "IX_CashDepositCustomerProfile_CustomerProfilesId",
                table: "CashDepositCustomerProfile",
                column: "CustomerProfilesId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProfileDebitCardIssuance_DebitCardIssuancesId",
                table: "CustomerProfileDebitCardIssuance",
                column: "DebitCardIssuancesId");

            migrationBuilder.CreateIndex(
                name: "IX_DomCustomers_CustomerProfilesId",
                table: "DomCustomers",
                column: "CustomerProfilesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankCreditCustomerProfile");

            migrationBuilder.DropTable(
                name: "BankDebitCustomerProfile");

            migrationBuilder.DropTable(
                name: "CashDepositCustomerProfile");

            migrationBuilder.DropTable(
                name: "CustomerProfileDebitCardIssuance");

            migrationBuilder.DropTable(
                name: "DomCustomers");

            migrationBuilder.DropTable(
                name: "FixedDeposits");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "SavingsAccounts");

            migrationBuilder.DropTable(
                name: "BankCredits");

            migrationBuilder.DropTable(
                name: "BankDebits");

            migrationBuilder.DropTable(
                name: "CashDeposits");

            migrationBuilder.DropTable(
                name: "debitCardIssuances");

            migrationBuilder.DropTable(
                name: "CustomerProfiles");
        }
    }
}
