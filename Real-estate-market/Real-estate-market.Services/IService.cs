﻿using Real_estate_market.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_estate_market.Services
{
    public interface IService<T,Tsearch>where T : class where Tsearch : class
    {
        IEnumerable<T> Get(Tsearch search = null);
        T GetById(int id);
    }

}
