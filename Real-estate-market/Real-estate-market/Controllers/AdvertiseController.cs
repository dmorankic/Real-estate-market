using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Real_estate_market.model.Requests;
using Real_estate_market.model.SearchObjects;
using Real_estate_market.Services;
using Real_estate_market.Services.Database;
using System.Data;

namespace Real_estate_market.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdvertiseController:BaseCRUDController<Advertise, AdvertiseSearchObject,AdvertiseUpsertRequest,AdvertiseUpsertRequest>
    {
        public AdvertiseController(IAdvertiseService advertiseService):base(advertiseService)
        {
         
        }
    }
}
 