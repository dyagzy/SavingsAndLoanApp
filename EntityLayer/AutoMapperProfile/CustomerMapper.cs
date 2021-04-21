using AutoMapper;
using EntityLayer.CustomerDetails;
using EntityLayer.Dto;
using EntityLayer.Loans;
using EntityLayer.Transaction;

namespace EntityLayer.AutoMapperProfile
{
    public class CustomerMapper : Profile
    {
        public CustomerMapper()
        {
            
            CreateMap<CustomerProfile,CustomerDto>();
            CreateMap<CustomerDto,CustomerProfile>();
            CreateMap<SavingsAccount, SavingsAccountDto>().ReverseMap();
            CreateMap<Loan, LoanDto>().ReverseMap();
            CreateMap<DepositMoney, DepositDto>().ReverseMap()
                .ForMember(dest => dest.AccountHolder,
                opt => opt.MapFrom(src => src.BeneficiaryAccountName));
                


        }
    }
}
