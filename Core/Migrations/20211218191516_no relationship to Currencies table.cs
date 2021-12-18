using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class norelationshiptoCurrenciestable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurrentBalances_Currencies_CurrencyId",
                table: "CurrentBalances");

            migrationBuilder.DropForeignKey(
                name: "FK_GuaranteeAmounts_Currencies_CurrencyId",
                table: "GuaranteeAmounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Installments_Currencies_CurrencyId",
                table: "Installments");

            migrationBuilder.DropForeignKey(
                name: "FK_OriginalAmounts_Currencies_CurrencyId",
                table: "OriginalAmounts");

            migrationBuilder.DropForeignKey(
                name: "FK_OverdueBalances_Currencies_CurrencyId",
                table: "OverdueBalances");

            migrationBuilder.DropIndex(
                name: "IX_OverdueBalances_CurrencyId",
                table: "OverdueBalances");

            migrationBuilder.DropIndex(
                name: "IX_OriginalAmounts_CurrencyId",
                table: "OriginalAmounts");

            migrationBuilder.DropIndex(
                name: "IX_Installments_CurrencyId",
                table: "Installments");

            migrationBuilder.DropIndex(
                name: "IX_GuaranteeAmounts_CurrencyId",
                table: "GuaranteeAmounts");

            migrationBuilder.DropIndex(
                name: "IX_CurrentBalances_CurrencyId",
                table: "CurrentBalances");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "OverdueBalances");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "OriginalAmounts");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "Installments");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "GuaranteeAmounts");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "CurrentBalances");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "OverdueBalances",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "OriginalAmounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Installments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "GuaranteeAmounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "CurrentBalances",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "OverdueBalances");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "OriginalAmounts");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Installments");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "GuaranteeAmounts");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "CurrentBalances");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "OverdueBalances",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "OriginalAmounts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "Installments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "GuaranteeAmounts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "CurrentBalances",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OverdueBalances_CurrencyId",
                table: "OverdueBalances",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_OriginalAmounts_CurrencyId",
                table: "OriginalAmounts",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Installments_CurrencyId",
                table: "Installments",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_GuaranteeAmounts_CurrencyId",
                table: "GuaranteeAmounts",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentBalances_CurrencyId",
                table: "CurrentBalances",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurrentBalances_Currencies_CurrencyId",
                table: "CurrentBalances",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GuaranteeAmounts_Currencies_CurrencyId",
                table: "GuaranteeAmounts",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Installments_Currencies_CurrencyId",
                table: "Installments",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OriginalAmounts_Currencies_CurrencyId",
                table: "OriginalAmounts",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OverdueBalances_Currencies_CurrencyId",
                table: "OverdueBalances",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");
        }
    }
}
