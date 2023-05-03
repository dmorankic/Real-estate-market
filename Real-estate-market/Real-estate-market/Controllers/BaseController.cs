using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Real_estate_market.model;
using Real_estate_market.model.SearchObjects;
using Real_estate_market.Services;

namespace Real_estate_market.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BaseController<T,TSearch> : ControllerBase where T : class where TSearch : class
    {
        public IService<T, TSearch> _service { get; set; }
        public BaseController(IService<T, TSearch> service) 
        { 
            _service=service;
        }

        [HttpGet]
        public IEnumerable<T> Get([FromQuery]TSearch search =null)
        {
            return _service.Get(search);
        }
        [HttpGet("{id}")]
        public T GetById(int id) { return _service.GetById(id); }
    }
}
