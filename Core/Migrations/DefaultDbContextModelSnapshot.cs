// <auto-generated />
using System;
using Core.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Core.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    partial class DefaultDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Entities.CreditInfo.BalanceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.ToTable("Balances");
                });

            modelBuilder.Entity("Core.Entities.CreditInfo.ContractDataEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CurrentBalanceId")
                        .HasColumnType("int");

                    b.Property<string>("DateAccountOpened")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfLastPayment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InstallmentAmountId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NextPaymentDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OriginalAmountId")
                        .HasColumnType("int");

                    b.Property<int?>("OverdueBalanceId")
                        .HasColumnType("int");

                    b.Property<string>("PhaseOfContract")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RealEndDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CurrentBalanceId");

                    b.HasIndex("InstallmentAmountId");

                    b.HasIndex("OriginalAmountId");

                    b.HasIndex("OverdueBalanceId");

                    b.ToTable("ContractData");
                });

            modelBuilder.Entity("Core.Entities.CreditInfo.ContractEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ContractCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ContractDataId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ContractDataId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("Core.Entities.CreditInfo.CurrencyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("Core.Entities.CreditInfo.CurrentBalanceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CurrentBalances");
                });

            modelBuilder.Entity("Core.Entities.CreditInfo.GuaranteeAmountEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GuaranteeAmounts");
                });

            modelBuilder.Entity("Core.Entities.CreditInfo.IndividualEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ContractEntityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ContractEntityId");

                    b.ToTable("Individuals");
                });

            modelBuilder.Entity("Core.Entities.CreditInfo.InstallmentAmountEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Installments");
                });

            modelBuilder.Entity("Core.Entities.CreditInfo.OriginalAmountEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OriginalAmounts");
                });

            modelBuilder.Entity("Core.Entities.CreditInfo.OverdueBalanceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OverdueBalances");
                });

            modelBuilder.Entity("Core.Entities.CreditInfo.SubjectRoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ContractEntityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GuaranteeAmountId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("RoleOfCustomer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ContractEntityId");

                    b.HasIndex("GuaranteeAmountId");

                    b.ToTable("SubjectRoles");
                });

            modelBuilder.Entity("Core.Entities.CreditInfo.ValidationFailedEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ContractCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ValidationError")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("XmlData")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FailedValidations");
                });

            modelBuilder.Entity("Core.Entities.CreditInfo.BalanceEntity", b =>
                {
                    b.HasOne("Core.Entities.CreditInfo.CurrencyEntity", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("Core.Entities.CreditInfo.ContractDataEntity", b =>
                {
                    b.HasOne("Core.Entities.CreditInfo.CurrentBalanceEntity", "CurrentBalance")
                        .WithMany()
                        .HasForeignKey("CurrentBalanceId");

                    b.HasOne("Core.Entities.CreditInfo.InstallmentAmountEntity", "InstallmentAmount")
                        .WithMany()
                        .HasForeignKey("InstallmentAmountId");

                    b.HasOne("Core.Entities.CreditInfo.OriginalAmountEntity", "OriginalAmount")
                        .WithMany()
                        .HasForeignKey("OriginalAmountId");

                    b.HasOne("Core.Entities.CreditInfo.OverdueBalanceEntity", "OverdueBalance")
                        .WithMany()
                        .HasForeignKey("OverdueBalanceId");

                    b.Navigation("CurrentBalance");

                    b.Navigation("InstallmentAmount");

                    b.Navigation("OriginalAmount");

                    b.Navigation("OverdueBalance");
                });

            modelBuilder.Entity("Core.Entities.CreditInfo.ContractEntity", b =>
                {
                    b.HasOne("Core.Entities.CreditInfo.ContractDataEntity", "ContractData")
                        .WithMany()
                        .HasForeignKey("ContractDataId");

                    b.Navigation("ContractData");
                });

            modelBuilder.Entity("Core.Entities.CreditInfo.IndividualEntity", b =>
                {
                    b.HasOne("Core.Entities.CreditInfo.ContractEntity", null)
                        .WithMany("Individual")
                        .HasForeignKey("ContractEntityId");
                });

            modelBuilder.Entity("Core.Entities.CreditInfo.SubjectRoleEntity", b =>
                {
                    b.HasOne("Core.Entities.CreditInfo.ContractEntity", null)
                        .WithMany("SubjectRole")
                        .HasForeignKey("ContractEntityId");

                    b.HasOne("Core.Entities.CreditInfo.GuaranteeAmountEntity", "GuaranteeAmount")
                        .WithMany()
                        .HasForeignKey("GuaranteeAmountId");

                    b.Navigation("GuaranteeAmount");
                });

            modelBuilder.Entity("Core.Entities.CreditInfo.ContractEntity", b =>
                {
                    b.Navigation("Individual");

                    b.Navigation("SubjectRole");
                });
#pragma warning restore 612, 618
        }
    }
}
