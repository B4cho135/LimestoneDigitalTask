using Core.Entities;
using Core.Entities.CreditInfo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistance
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {

        }
        public DefaultDbContext()
        {

        }

        public DbSet<BalanceEntity> Balances { get; set; }
        public DbSet<OriginalAmountEntity> OriginalAmounts { get; set; }
        public DbSet<CurrentBalanceEntity> CurrentBalances { get; set; }
        public DbSet<GuaranteeAmountEntity> GuaranteeAmounts { get; set; }
        public DbSet<OverdueBalanceEntity> OverdueBalances { get; set; }
        public DbSet<ContractDataEntity> ContractData { get; set; }
        public DbSet<ContractEntity> Contracts { get; set; }
        public DbSet<CurrencyEntity> Currencies { get; set; }
        public DbSet<IndividualEntity> Individuals { get; set; }
        public DbSet<SubjectRoleEntity> SubjectRoles { get; set; }
        public DbSet<InstallmentAmountEntity> Installments { get; set; }
        public DbSet<ValidationFailedEntity> FailedValidations { get; set; }


        //this is just for usage in consoel app
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=BACHO\\SQLEXPRESS;Initial Catalog=Limestone;Integrated Security=True");
            }
        }
    }
}
