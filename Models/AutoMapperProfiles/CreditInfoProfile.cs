using AutoMapper;
using Core.Entities.CreditInfo;
using Models.CreditInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.AutoMapperProfiles
{
    public class CreditInfoProfile : Profile
    {
        public CreditInfoProfile()
        {
            CreateMap<Contract, ContractEntity>()
                .ForMember(dest => dest.ContractCode, opt => opt.MapFrom(src => src.ContractCode))
                .ForMember(dest => dest.Individual, opt => opt.MapFrom(src => src.Individual))
                .ForAllOtherMembers(opts => opts.Ignore());
        }
    }
}
