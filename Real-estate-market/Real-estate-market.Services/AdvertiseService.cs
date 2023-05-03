
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Real_estate_market.model.Requests;
using Real_estate_market.model.SearchObjects;
using Real_estate_market.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_estate_market.Services
{
    public class AdvertiseService : BaseCRUDService<Advertise, Advertise, AdvertiseSearchObject, AdvertiseUpsertRequest, AdvertiseUpsertRequest>
        , IAdvertiseService
    {
        public AdvertiseService(RealEstateContext Context, IMapper Mapper) : base(Context, Mapper)
        {

        }
    }
}
