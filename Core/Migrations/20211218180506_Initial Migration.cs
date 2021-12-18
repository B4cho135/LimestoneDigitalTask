using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FailedValidations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValidationError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XmlData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FailedValidations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Balances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Balances_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CurrentBalances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentBalances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrentBalances_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GuaranteeAmounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuaranteeAmounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuaranteeAmounts_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Installments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Installments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Installments_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OriginalAmounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OriginalAmounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OriginalAmounts_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OverdueBalances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverdueBalances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OverdueBalances_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContractData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhaseOfContract = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalAmountId = table.Column<int>(type: "int", nullable: true),
                    InstallmentAmountId = table.Column<int>(type: "int", nullable: true),
                    CurrentBalanceId = table.Column<int>(type: "int", nullable: true),
                    OverdueBalanceId = table.Column<int>(type: "int", nullable: true),
                    DateOfLastPayment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextPaymentDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAccountOpened = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RealEndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractData_CurrentBalances_CurrentBalanceId",
                        column: x => x.CurrentBalanceId,
                        principalTable: "CurrentBalances",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContractData_Installments_InstallmentAmountId",
                        column: x => x.InstallmentAmountId,
                        principalTable: "Installments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContractData_OriginalAmounts_OriginalAmountId",
                        column: x => x.OriginalAmountId,
                        principalTable: "OriginalAmounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContractData_OverdueBalances_OverdueBalanceId",
                        column: x => x.OverdueBalanceId,
                        principalTable: "OverdueBalances",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractDataId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_ContractData_ContractDataId",
                        column: x => x.ContractDataId,
                        principalTable: "ContractData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Individuals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractEntityId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individuals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Individuals_Contracts_ContractEntityId",
                        column: x => x.ContractEntityId,
                        principalTable: "Contracts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubjectRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleOfCustomer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuaranteeAmountId = table.Column<int>(type: "int", nullable: true),
                    ContractEntityId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectRoles_Contracts_ContractEntityId",
                        column: x => x.ContractEntityId,
                        principalTable: "Contracts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubjectRoles_GuaranteeAmounts_GuaranteeAmountId",
                        column: x => x.GuaranteeAmountId,
                        principalTable: "GuaranteeAmounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Balances_CurrencyId",
                table: "Balances",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractData_CurrentBalanceId",
                table: "ContractData",
                column: "CurrentBalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractData_InstallmentAmountId",
                table: "ContractData",
                column: "InstallmentAmountId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractData_OriginalAmountId",
                table: "ContractData",
                column: "OriginalAmountId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractData_OverdueBalanceId",
                table: "ContractData",
                column: "OverdueBalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ContractDataId",
                table: "Contracts",
                column: "ContractDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentBalances_CurrencyId",
                table: "CurrentBalances",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_GuaranteeAmounts_CurrencyId",
                table: "GuaranteeAmounts",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Individuals_ContractEntityId",
                table: "Individuals",
                column: "ContractEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Installments_CurrencyId",
                table: "Installments",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_OriginalAmounts_CurrencyId",
                table: "OriginalAmounts",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_OverdueBalances_CurrencyId",
                table: "OverdueBalances",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectRoles_ContractEntityId",
                table: "SubjectRoles",
                column: "ContractEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectRoles_GuaranteeAmountId",
                table: "SubjectRoles",
                column: "GuaranteeAmountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Balances");

            migrationBuilder.DropTable(
                name: "FailedValidations");

            migrationBuilder.DropTable(
                name: "Individuals");

            migrationBuilder.DropTable(
                name: "SubjectRoles");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "GuaranteeAmounts");

            migrationBuilder.DropTable(
                name: "ContractData");

            migrationBuilder.DropTable(
                name: "CurrentBalances");

            migrationBuilder.DropTable(
                name: "Installments");

            migrationBuilder.DropTable(
                name: "OriginalAmounts");

            migrationBuilder.DropTable(
                name: "OverdueBalances");

            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
