using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityLayer.Migrations
{
    public partial class addedDepositMoneyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepositMoney_CustomerProfiles_CustomerProfileId",
                table: "DepositMoney");

            migrationBuilder.DropColumn(
                name: "CurrentBalance",
                table: "DepositMoney");

            migrationBuilder.RenameColumn(
                name: "CustomerProfileId",
                table: "DepositMoney",
                newName: "SavingsAccountId");

            migrationBuilder.RenameColumn(
                name: "AccountNumber",
                table: "DepositMoney",
                newName: "PhoneOfDepositor");

            migrationBuilder.RenameIndex(
                name: "IX_DepositMoney_CustomerProfileId",
                table: "DepositMoney",
                newName: "IX_DepositMoney_SavingsAccountId");

            migrationBuilder.AddColumn<decimal>(
                name: "Credit",
                table: "SavingsAccounts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Debit",
                table: "SavingsAccounts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "SavingsAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherNames",
                table: "SavingsAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SurName",
                table: "SavingsAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateofDeposit",
                table: "DepositMoney",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NameofDepositor",
                table: "DepositMoney",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DepositMoney_SavingsAccounts_SavingsAccountId",
                table: "DepositMoney",
                column: "SavingsAccountId",
                principalTable: "SavingsAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepositMoney_SavingsAccounts_SavingsAccountId",
                table: "DepositMoney");

            migrationBuilder.DropColumn(
                name: "Credit",
                table: "SavingsAccounts");

            migrationBuilder.DropColumn(
                name: "Debit",
                table: "SavingsAccounts");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "SavingsAccounts");

            migrationBuilder.DropColumn(
                name: "OtherNames",
                table: "SavingsAccounts");

            migrationBuilder.DropColumn(
                name: "SurName",
                table: "SavingsAccounts");

            migrationBuilder.DropColumn(
                name: "DateofDeposit",
                table: "DepositMoney");

            migrationBuilder.DropColumn(
                name: "NameofDepositor",
                table: "DepositMoney");

            migrationBuilder.RenameColumn(
                name: "SavingsAccountId",
                table: "DepositMoney",
                newName: "CustomerProfileId");

            migrationBuilder.RenameColumn(
                name: "PhoneOfDepositor",
                table: "DepositMoney",
                newName: "AccountNumber");

            migrationBuilder.RenameIndex(
                name: "IX_DepositMoney_SavingsAccountId",
                table: "DepositMoney",
                newName: "IX_DepositMoney_CustomerProfileId");

            migrationBuilder.AddColumn<decimal>(
                name: "CurrentBalance",
                table: "DepositMoney",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_DepositMoney_CustomerProfiles_CustomerProfileId",
                table: "DepositMoney",
                column: "CustomerProfileId",
                principalTable: "CustomerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
