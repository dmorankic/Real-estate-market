using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Real_estate_market.Services;
using Real_estate_market.model;
using Real_estate_market.model.SearchObjects;

namespace Real_estate_market.Controllers
{
    public class UserController : BaseController<UserModel,UserSearchObject>
    { 
        public UserController(IUserService userService):base(userService)
        {
      
        }
       
    }
}
