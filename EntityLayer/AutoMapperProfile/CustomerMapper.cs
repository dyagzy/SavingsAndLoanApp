using AutoMapper;
using EntityLayer.CustomerDetails;
using EntityLayer.Dto;

namespace EntityLayer.AutoMapperProfile
{
    public class CustomerMapper : Profile
    {
        public CustomerMapper()
        {
            
            CreateMap<CustomerProfile,CustomerDto>();
            CreateMap<CustomerDto,CustomerProfile>();
           

        }
    }
}
