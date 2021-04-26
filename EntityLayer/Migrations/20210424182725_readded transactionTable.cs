using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityLayer.Migrations
{
    public partial class readdedtransactionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfTransaction",
                table: "SavingsAccounts");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "SavingsAccounts");

            migrationBuilder.DropColumn(
                name: "TransactionAmount",
                table: "SavingsAccounts");

            migrationBuilder.DropColumn(
                name: "TransactionComment",
                table: "SavingsAccounts");

            migrationBuilder.DropColumn(
                name: "TransactionHistorySearchPeriod",
                table: "SavingsAccounts");

            migrationBuilder.DropColumn(
                name: "TransactionRecipientBankName",
                table: "SavingsAccounts");

            migrationBuilder.DropColumn(
                name: "TransactionRecipientName",
                table: "SavingsAccounts");

            migrationBuilder.DropColumn(
                name: "TransactionType",
                table: "SavingsAccounts");

            migrationBuilder.DropColumn(
                name: "NameofDepositor",
                table: "DepositMonies");

            migrationBuilder.RenameColumn(
                name: "DateofDeposit",
                table: "DepositMonies",
                newName: "DepositDate");

            migrationBuilder.CreateTable(
                name: "TransactionHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfDepositor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepositDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Narrative = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountWithdraw = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WithdrawlDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionHistories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WithdrawMoney",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountWithdraw = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrentBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Narrative = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WithdrawlDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepositMoneyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WithdrawMoney", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WithdrawMoney_DepositMonies_DepositMoneyId",
                        column: x => x.DepositMoneyId,
                        principalTable: "DepositMonies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WithdrawMoney_DepositMoneyId",
                table: "WithdrawMoney",
                column: "DepositMoneyId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionHistories");

            migrationBuilder.DropTable(
                name: "WithdrawMoney");

            migrationBuilder.RenameColumn(
                name: "DepositDate",
                table: "DepositMonies",
                newName: "DateofDeposit");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfTransaction",
                table: "SavingsAccounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "SavingsAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TransactionAmount",
                table: "SavingsAccounts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransactionComment",
                table: "SavingsAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TransactionHistorySearchPeriod",
                table: "SavingsAccounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransactionRecipientBankName",
                table: "SavingsAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransactionRecipientName",
                table: "SavingsAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransactionType",
                table: "SavingsAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameofDepositor",
                table: "DepositMonies",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
