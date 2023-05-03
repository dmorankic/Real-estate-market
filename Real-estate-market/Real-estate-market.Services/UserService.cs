using Real_estate_market.Services.Database;
using Real_estate_market.model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using AutoMapper;
using Real_estate_market.model.SearchObjects;

namespace Real_estate_market.Services
{
    public class UserService :BaseService<User,UserModel,UserSearchObject>, IUserService
    {
        public UserService(RealEstateContext Context, IMapper Mapper):base(Context,Mapper)
        {
     
        }

        public override IEnumerable<UserModel> Get(UserSearchObject search = null)
        {
            return base.Get(search);
        }

        public override IQueryable<User> AddFilter(IQueryable<User> query, UserSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.FirstName))
            {
                filteredQuery = filteredQuery.Where(x => x.FirstName == search.FirstName);
            }

            if (search?.DateRegistered.HasValue==true)
            {
                filteredQuery = filteredQuery.Where(x => x.DateRegistered==search.DateRegistered);
            }

            return filteredQuery;
        }
    }
}
