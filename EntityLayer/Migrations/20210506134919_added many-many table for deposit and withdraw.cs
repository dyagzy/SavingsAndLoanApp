using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityLayer.Migrations
{
    public partial class addedmanymanytablefordepositandwithdraw : Migration
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

            migrationBuilder.AddColumn<int>(
                name: "TransactionHistoryId",
                table: "DepositMonies",
                type: "int",
                nullable: true);

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
                });

            migrationBuilder.CreateTable(
                name: "DepositMoneyWithdrawMoney",
                columns: table => new
                {
                    DepositMoneyId = table.Column<int>(type: "int", nullable: false),
                    WithdrawMoneyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositMoneyWithdrawMoney", x => new { x.DepositMoneyId, x.WithdrawMoneyId });
                    table.ForeignKey(
                        name: "FK_DepositMoneyWithdrawMoney_DepositMonies_DepositMoneyId",
                        column: x => x.DepositMoneyId,
                        principalTable: "DepositMonies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepositMoneyWithdrawMoney_WithdrawMoney_WithdrawMoneyId",
                        column: x => x.WithdrawMoneyId,
                        principalTable: "WithdrawMoney",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepositWithdraws",
                columns: table => new
                {
                    DepositMoneyId = table.Column<int>(type: "int", nullable: false),
                    WithdrawMoneyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositWithdraws", x => new { x.WithdrawMoneyId, x.DepositMoneyId });
                    table.ForeignKey(
                        name: "FK_DepositWithdraws_DepositMonies_DepositMoneyId",
                        column: x => x.DepositMoneyId,
                        principalTable: "DepositMonies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepositWithdraws_WithdrawMoney_WithdrawMoneyId",
                        column: x => x.WithdrawMoneyId,
                        principalTable: "WithdrawMoney",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransactionHistoryWithdrawMoney",
                columns: table => new
                {
                    TransactionHistoriesId = table.Column<int>(type: "int", nullable: false),
                    WithdrawMoneyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionHistoryWithdrawMoney", x => new { x.TransactionHistoriesId, x.WithdrawMoneyId });
                    table.ForeignKey(
                        name: "FK_TransactionHistoryWithdrawMoney_TransactionHistories_TransactionHistoriesId",
                        column: x => x.TransactionHistoriesId,
                        principalTable: "TransactionHistories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionHistoryWithdrawMoney_WithdrawMoney_WithdrawMoneyId",
                        column: x => x.WithdrawMoneyId,
                        principalTable: "WithdrawMoney",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepositMonies_TransactionHistoryId",
                table: "DepositMonies",
                column: "TransactionHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositMoneyWithdrawMoney_WithdrawMoneyId",
                table: "DepositMoneyWithdrawMoney",
                column: "WithdrawMoneyId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositWithdraws_DepositMoneyId",
                table: "DepositWithdraws",
                column: "DepositMoneyId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionHistoryWithdrawMoney_WithdrawMoneyId",
                table: "TransactionHistoryWithdrawMoney",
                column: "WithdrawMoneyId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepositMonies_TransactionHistories_TransactionHistoryId",
                table: "DepositMonies",
                column: "TransactionHistoryId",
                principalTable: "TransactionHistories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepositMonies_TransactionHistories_TransactionHistoryId",
                table: "DepositMonies");

            migrationBuilder.DropTable(
                name: "DepositMoneyWithdrawMoney");

            migrationBuilder.DropTable(
                name: "DepositWithdraws");

            migrationBuilder.DropTable(
                name: "TransactionHistoryWithdrawMoney");

            migrationBuilder.DropTable(
                name: "TransactionHistories");

            migrationBuilder.DropTable(
                name: "WithdrawMoney");

            migrationBuilder.DropIndex(
                name: "IX_DepositMonies_TransactionHistoryId",
                table: "DepositMonies");

            migrationBuilder.DropColumn(
                name: "TransactionHistoryId",
                table: "DepositMonies");

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
