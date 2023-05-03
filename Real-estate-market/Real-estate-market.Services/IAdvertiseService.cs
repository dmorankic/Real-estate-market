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
    public interface IAdvertiseService:ICRUDService<Advertise,AdvertiseSearchObject,AdvertiseUpsertRequest,AdvertiseUpsertRequest>
    {
       
    }
}
