using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Real_estate_market.model.SearchObjects;
using Real_estate_market.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_estate_market.Services
{
    public class BaseCRUDService<TDb, T, TSearch, TInsert, TUpdate> : BaseService<TDb, T, TSearch>,ICRUDService<T,TSearch,TInsert,TUpdate>
        where TDb : class where TSearch : BaseSearchObject where TInsert : class where TUpdate : class where T : class
    {
        public BaseCRUDService(RealEstateContext Context, IMapper Mapper) : base(Context, Mapper)
        {
        }

        public T Insert(TInsert insert)
        {
            var set = Context.Set<TDb>();
            TDb insertEntity=Mapper.Map<TDb>(insert);
            set.Add(insertEntity);
            Context.SaveChanges();
            return Mapper.Map<T>(insertEntity);
        }
        public T Update(int id,TUpdate update)
        {
            var set = Context.Set<TDb>();
            var entity = set.Find(id);
            if(entity != null)
            {
                Mapper.Map(update, entity);
            }
            else
            {
                return null;
            }
            Context.SaveChanges();
            return Mapper.Map<T>(entity);
        }
    }

}
