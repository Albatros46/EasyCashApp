using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashApp.DataAccess.Migrations
{
    public partial class MigParaTransferIslemi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReceiverId",
                table: "CustomerAccountsProcess",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderId",
                table: "CustomerAccountsProcess",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccountsProcess_ReceiverId",
                table: "CustomerAccountsProcess",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccountsProcess_SenderId",
                table: "CustomerAccountsProcess",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountsProcess_CustomerAccounts_ReceiverId",
                table: "CustomerAccountsProcess",
                column: "ReceiverId",
                principalTable: "CustomerAccounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountsProcess_CustomerAccounts_SenderId",
                table: "CustomerAccountsProcess",
                column: "SenderId",
                principalTable: "CustomerAccounts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountsProcess_CustomerAccounts_ReceiverId",
                table: "CustomerAccountsProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountsProcess_CustomerAccounts_SenderId",
                table: "CustomerAccountsProcess");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccountsProcess_ReceiverId",
                table: "CustomerAccountsProcess");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccountsProcess_SenderId",
                table: "CustomerAccountsProcess");

            migrationBuilder.DropColumn(
                name: "ReceiverId",
                table: "CustomerAccountsProcess");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "CustomerAccountsProcess");
        }
    }
}
