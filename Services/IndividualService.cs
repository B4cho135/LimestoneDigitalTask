using Application;
using AutoMapper;
using Core.Entities.CreditInfo;
using Core.Persistance;
using Microsoft.EntityFrameworkCore;
using Models.CreditInfo;
using Models.Dto.CreditInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class IndividualService : GenericService<IndividualEntity, Individual>, IIndividualService
    {
        public IndividualService(DefaultDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<DetailsDto> GetDetailsBy(string nationalId)
        {
            var contract = await Context.Contracts
                .Include(x => x.Individual)
                .Include(x => x.SubjectRole)
                    .Include("SubjectRole.GuaranteeAmount")
                .Include(x => x.ContractData)
                    .Include("ContractData.CurrentBalance")
                    .Include("ContractData.OverdueBalance")
                    .Include("ContractData.OriginalAmount")
                    .Include("ContractData.InstallmentAmount")
                .FirstOrDefaultAsync(x => x.Individual.FirstOrDefault(i => i.NationalId == nationalId) != null);


            var details = new DetailsDto();

            details.Contract = new ContractDto()
            { 
                CurrentBalance = new CurrentBalance()
                {
                    Value = contract.ContractData.CurrentBalance.Value,
                    Currency = contract.ContractData.CurrentBalance.Currency
                },
                OverdueBalance = new OverdueBalance()
                {
                    Value = contract.ContractData.OverdueBalance.Value,
                    Currency = contract.ContractData.OverdueBalance.Currency
                },
                InstallmentAmount = new InstallmentAmount()
                {
                    Value = contract.ContractData.InstallmentAmount.Value,
                    Currency = contract.ContractData.InstallmentAmount.Currency
                },
                OriginalAmount = new OriginalAmount()
                {
                    Value = contract.ContractData.OriginalAmount.Value,
                    Currency = contract.ContractData.OriginalAmount.Currency
                },
                DateAccountOpened = contract.ContractData.DateAccountOpened,
                DateOfLastPayment = contract.ContractData.DateOfLastPayment,
                NextPaymentDate = contract.ContractData.NextPaymentDate,
                PhaseOfContract = contract.ContractData.PhaseOfContract,
                RealEndDate = contract.ContractData.RealEndDate

            };

            

            var individual = contract.Individual.FirstOrDefault(x => x.NationalId == nationalId);

            if (individual != null)
            {
                details.Individual = new IndividualDto()
                {
                    NationalId = nationalId,
                    BirthDate = individual.DateOfBirth,
                    FirstName = individual.FirstName,
                    LastName = individual.LastName,
                    Gender = individual.Gender
                };

            }

            
            //check DetailsDto Model for explanation of why I did not implement this part

            //details.SummaryInformation = new Summary()
            //{ 
            //    MaxOverdueBalance = contract.ContractData.OverdueBalance.
            //};



            return details;
        }

        public async Task<IndividualEntity> SearchByNationalId(string nationalId)
        {
            var individual = await Context.Individuals.FirstOrDefaultAsync(x => x.NationalId == nationalId);

            return individual;
        }
    }
}
