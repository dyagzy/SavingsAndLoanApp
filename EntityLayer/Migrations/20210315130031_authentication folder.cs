using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityLayer.Migrations
{
    public partial class authenticationfolder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProfiles_BankDebit_BankDebitsId",
                table: "CustomerProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentRecords_Loans_LoanId",
                table: "PaymentRecords");

            migrationBuilder.DropIndex(
                name: "IX_PaymentRecords_LoanId",
                table: "PaymentRecords");

            migrationBuilder.DropIndex(
                name: "IX_LoanType_LoanId",
                table: "LoanType");

            migrationBuilder.DropIndex(
                name: "IX_CustomerProfiles_BankDebitsId",
                table: "CustomerProfiles");

            migrationBuilder.DropColumn(
                name: "BankDebitsId",
                table: "CustomerProfiles");

            migrationBuilder.RenameColumn(
                name: "LoanId",
                table: "PaymentRecords",
                newName: "LoadId");

            migrationBuilder.AlterColumn<decimal>(
                name: "InitialBal",
                table: "SavingsAccounts",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentBalance",
                table: "SavingsAccounts",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "LoadId",
                table: "RepayLoan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TenureTypeId",
                table: "RepayLoan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LoanAmount",
                table: "Loans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "PaymentRecordId",
                table: "Loans",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "FixedDeposits",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Principal",
                table: "FixedDeposits",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Interest",
                table: "FixedDeposits",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmountDue",
                table: "FixedDeposits",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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
                        name: "FK_BankDebitCustomerProfile_BankDebit_BankDebitsId",
                        column: x => x.BankDebitsId,
                        principalTable: "BankDebit",
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
                name: "TenorType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Days = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Weeks = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Month = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenorType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TenorType_Loans_LoanId",
                        column: x => x.LoanId,
                        principalTable: "Loans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RepayLoan_TenureTypeId",
                table: "RepayLoan",
                column: "TenureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanType_LoanId",
                table: "LoanType",
                column: "LoanId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_PaymentRecordId",
                table: "Loans",
                column: "PaymentRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_BankDebitCustomerProfile_CustomerProfilesId",
                table: "BankDebitCustomerProfile",
                column: "CustomerProfilesId");

            migrationBuilder.CreateIndex(
                name: "IX_TenorType_LoanId",
                table: "TenorType",
                column: "LoanId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_PaymentRecords_PaymentRecordId",
                table: "Loans",
                column: "PaymentRecordId",
                principalTable: "PaymentRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RepayLoan_Tenors_TenureTypeId",
                table: "RepayLoan",
                column: "TenureTypeId",
                principalTable: "Tenors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_PaymentRecords_PaymentRecordId",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_RepayLoan_Tenors_TenureTypeId",
                table: "RepayLoan");

            migrationBuilder.DropTable(
                name: "BankDebitCustomerProfile");

            migrationBuilder.DropTable(
                name: "TenorType");

            migrationBuilder.DropIndex(
                name: "IX_RepayLoan_TenureTypeId",
                table: "RepayLoan");

            migrationBuilder.DropIndex(
                name: "IX_LoanType_LoanId",
                table: "LoanType");

            migrationBuilder.DropIndex(
                name: "IX_Loans_PaymentRecordId",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "LoadId",
                table: "RepayLoan");

            migrationBuilder.DropColumn(
                name: "TenureTypeId",
                table: "RepayLoan");

            migrationBuilder.DropColumn(
                name: "LoanAmount",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "PaymentRecordId",
                table: "Loans");

            migrationBuilder.RenameColumn(
                name: "LoadId",
                table: "PaymentRecords",
                newName: "LoanId");

            migrationBuilder.AlterColumn<decimal>(
                name: "InitialBal",
                table: "SavingsAccounts",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentBalance",
                table: "SavingsAccounts",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "FixedDeposits",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Principal",
                table: "FixedDeposits",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Interest",
                table: "FixedDeposits",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmountDue",
                table: "FixedDeposits",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AddColumn<int>(
                name: "BankDebitsId",
                table: "CustomerProfiles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentRecords_LoanId",
                table: "PaymentRecords",
                column: "LoanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoanType_LoanId",
                table: "LoanType",
                column: "LoanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProfiles_BankDebitsId",
                table: "CustomerProfiles",
                column: "BankDebitsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProfiles_BankDebit_BankDebitsId",
                table: "CustomerProfiles",
                column: "BankDebitsId",
                principalTable: "BankDebit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentRecords_Loans_LoanId",
                table: "PaymentRecords",
                column: "LoanId",
                principalTable: "Loans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
