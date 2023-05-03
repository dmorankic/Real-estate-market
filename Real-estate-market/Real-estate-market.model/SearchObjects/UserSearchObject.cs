using System;
using System.Collections.Generic;
using System.Text;

namespace Real_estate_market.model.SearchObjects
{
    public class UserSearchObject:BaseSearchObject
    {
        public string FirstName { get; set; }
        public DateTime? DateRegistered { get; set; }
    }
}
