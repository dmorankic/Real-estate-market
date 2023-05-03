using System;
using System.Collections.Generic;
using System.Text;

namespace Real_estate_market.model.Requests
{
    public class AdvertiseUpsertRequest
    {
        public string Status { get; set; }

        public string Type { get; set; }

        public DateTime DateCreated { get; set; }

        public int UserId { get; set; }

        public int PropertyId { get; set; }
    }
}
