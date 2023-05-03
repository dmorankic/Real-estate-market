using AutoMapper;
using Real_estate_market.model;
using Real_estate_market.model.Requests;
using Real_estate_market.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_estate_market.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User,UserModel>();
            CreateMap<AdvertiseUpsertRequest, Advertise>();
            CreateMap<AdvertiseUpsertRequest, AdvertiseModel>();
            CreateMap<Advertise, Advertise>();



        }
    }
}
