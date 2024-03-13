using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Rently.DTOs;
using Rently.Models;

namespace Rently.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<CustomerDTO, Customer>()
                .ForMember(member => member.Id, opt => opt.Ignore());
            Mapper.CreateMap<Customer, CustomerDTO>();



            Mapper.CreateMap<CarDTO, Car>()
                .ForMember(member => member.Id, opt => opt.Ignore());
            Mapper.CreateMap<Car, CarDTO>();

    
            Mapper.CreateMap<MembershipType, MembershipTypeDTO>();

            Mapper.CreateMap<CarType, CarTypeDTO>();

        }
    }
}