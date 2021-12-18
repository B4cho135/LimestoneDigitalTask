using Core.Entities.CreditInfo;
using Models.CreditInfo;
using Models.Dto.CreditInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IIndividualService : IGenericService<IndividualEntity, Individual>
    {
        Task<IndividualEntity> SearchByNationalId(string nationalId);
        Task<DetailsDto> GetDetailsBy(string nationalId);
    }
}
