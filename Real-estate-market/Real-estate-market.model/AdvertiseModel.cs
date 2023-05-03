using System;
using System.Collections.Generic;
using System.Text;

namespace Real_estate_market.model
{
    public  class AdvertiseModel
    {
        public string Status { get; set; }

        public string Type { get; set; }

        public DateTime? DateCreated { get; set; }

        public int? UserId { get; set; }

        public int? PropertyId { get; set; }

        //public virtual Property Property { get; set; }

        //public virtual User User { get; set; }
    }
}
