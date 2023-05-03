using System;
using System.Collections.Generic;

namespace Real_estate_market.Services.Database;

public partial class Address
{
    public int Id { get; set; }

    public string? NumberStreet { get; set; }

    public string? ZipCode { get; set; }

    public int? CityId { get; set; }

    public virtual City? City { get; set; }
}
