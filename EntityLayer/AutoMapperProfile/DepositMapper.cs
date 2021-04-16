using AutoMapper;
using EntityLayer.Dto;
using EntityLayer.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.AutoMapperProfile
{
    public class DepositMapper : Profile
    {
        public DepositMapper()
        {
            CreateMap<DepositMoney, DepositDto>().ReverseMap();
        }
    }
}
