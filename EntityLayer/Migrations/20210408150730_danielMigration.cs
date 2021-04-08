using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityLayer.Migrations
{
    public partial class danielMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProfileDebitCardIssuance_debitCardIssuances_DebitCardIssuancesId",
                table: "CustomerProfileDebitCardIssuance");

            migrationBuilder.DropForeignKey(
                name: "FK_RepayLoan_Loans_LoanId",
                table: "RepayLoan");

            migrationBuilder.DropForeignKey(
                name: "FK_RepayLoan_Tenors_TenureTypeId",
                table: "RepayLoan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_debitCardIssuances",
                table: "debitCardIssuances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RepayLoan",
                table: "RepayLoan");

            migrationBuilder.DropColumn(
                name: "LoadId",
                table: "RepayLoan");

            migrationBuilder.RenameTable(
                name: "debitCardIssuances",
                newName: "DebitCardIssuances");

            migrationBuilder.RenameTable(
                name: "RepayLoan",
                newName: "RepayLoans");

            migrationBuilder.RenameIndex(
                name: "IX_RepayLoan_TenureTypeId",
                table: "RepayLoans",
                newName: "IX_RepayLoans_TenureTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_RepayLoan_LoanId",
                table: "RepayLoans",
                newName: "IX_RepayLoans_LoanId");

            migrationBuilder.AddColumn<int>(
                name: "LoanCustomerId",
                table: "LoanType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ApproveLoanId",
                table: "Loans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Signature",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumberOfNextOfKin",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "OtherNames",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "NameOfNextOfKin",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AccountType",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<byte>(
                name: "ProfilePicture",
                table: "Admins",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerProfileId",
                table: "RepayLoans",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DebitCardIssuances",
                table: "DebitCardIssuances",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepayLoans",
                table: "RepayLoans",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ApproveLoan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoanValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SavingsAccountId = table.Column<int>(type: "int", nullable: true),
                    LoanTypeId = table.Column<int>(type: "int", nullable: false),
                    CustomerProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApproveLoan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApproveLoan_CustomerProfiles_CustomerProfileId",
                        column: x => x.CustomerProfileId,
                        principalTable: "CustomerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApproveLoan_LoanType_LoanTypeId",
                        column: x => x.LoanTypeId,
                        principalTable: "LoanType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApproveLoan_SavingsAccounts_SavingsAccountId",
                        column: x => x.SavingsAccountId,
                        principalTable: "SavingsAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoanCustomer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanCustomer", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoanType_LoanCustomerId",
                table: "LoanType",
                column: "LoanCustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Loans_ApproveLoanId",
                table: "Loans",
                column: "ApproveLoanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RepayLoans_CustomerProfileId",
                table: "RepayLoans",
                column: "CustomerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ApproveLoan_CustomerProfileId",
                table: "ApproveLoan",
                column: "CustomerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ApproveLoan_LoanTypeId",
                table: "ApproveLoan",
                column: "LoanTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApproveLoan_SavingsAccountId",
                table: "ApproveLoan",
                column: "SavingsAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProfileDebitCardIssuance_DebitCardIssuances_DebitCardIssuancesId",
                table: "CustomerProfileDebitCardIssuance",
                column: "DebitCardIssuancesId",
                principalTable: "DebitCardIssuances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_ApproveLoan_ApproveLoanId",
                table: "Loans",
                column: "ApproveLoanId",
                principalTable: "ApproveLoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanType_LoanCustomer_LoanCustomerId",
                table: "LoanType",
                column: "LoanCustomerId",
                principalTable: "LoanCustomer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepayLoans_CustomerProfiles_CustomerProfileId",
                table: "RepayLoans",
                column: "CustomerProfileId",
                principalTable: "CustomerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RepayLoans_Loans_LoanId",
                table: "RepayLoans",
                column: "LoanId",
                principalTable: "Loans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RepayLoans_Tenors_TenureTypeId",
                table: "RepayLoans",
                column: "TenureTypeId",
                principalTable: "Tenors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProfileDebitCardIssuance_DebitCardIssuances_DebitCardIssuancesId",
                table: "CustomerProfileDebitCardIssuance");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_ApproveLoan_ApproveLoanId",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanType_LoanCustomer_LoanCustomerId",
                table: "LoanType");

            migrationBuilder.DropForeignKey(
                name: "FK_RepayLoans_CustomerProfiles_CustomerProfileId",
                table: "RepayLoans");

            migrationBuilder.DropForeignKey(
                name: "FK_RepayLoans_Loans_LoanId",
                table: "RepayLoans");

            migrationBuilder.DropForeignKey(
                name: "FK_RepayLoans_Tenors_TenureTypeId",
                table: "RepayLoans");

            migrationBuilder.DropTable(
                name: "ApproveLoan");

            migrationBuilder.DropTable(
                name: "LoanCustomer");

            migrationBuilder.DropIndex(
                name: "IX_LoanType_LoanCustomerId",
                table: "LoanType");

            migrationBuilder.DropIndex(
                name: "IX_Loans_ApproveLoanId",
                table: "Loans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DebitCardIssuances",
                table: "DebitCardIssuances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RepayLoans",
                table: "RepayLoans");

            migrationBuilder.DropIndex(
                name: "IX_RepayLoans_CustomerProfileId",
                table: "RepayLoans");

            migrationBuilder.DropColumn(
                name: "LoanCustomerId",
                table: "LoanType");

            migrationBuilder.DropColumn(
                name: "ApproveLoanId",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "CustomerProfileId",
                table: "RepayLoans");

            migrationBuilder.RenameTable(
                name: "DebitCardIssuances",
                newName: "debitCardIssuances");

            migrationBuilder.RenameTable(
                name: "RepayLoans",
                newName: "RepayLoan");

            migrationBuilder.RenameIndex(
                name: "IX_RepayLoans_TenureTypeId",
                table: "RepayLoan",
                newName: "IX_RepayLoan_TenureTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_RepayLoans_LoanId",
                table: "RepayLoan",
                newName: "IX_RepayLoan_LoanId");

            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "CustomerProfiles",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Signature",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumberOfNextOfKin",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OtherNames",
                table: "CustomerProfiles",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameOfNextOfKin",
                table: "CustomerProfiles",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "CustomerProfiles",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountType",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "ProfilePicture",
                table: "Admins",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoadId",
                table: "RepayLoan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_debitCardIssuances",
                table: "debitCardIssuances",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepayLoan",
                table: "RepayLoan",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProfileDebitCardIssuance_debitCardIssuances_DebitCardIssuancesId",
                table: "CustomerProfileDebitCardIssuance",
                column: "DebitCardIssuancesId",
                principalTable: "debitCardIssuances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepayLoan_Loans_LoanId",
                table: "RepayLoan",
                column: "LoanId",
                principalTable: "Loans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepayLoan_Tenors_TenureTypeId",
                table: "RepayLoan",
                column: "TenureTypeId",
                principalTable: "Tenors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
