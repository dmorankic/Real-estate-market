﻿using System;
using System.Collections.Generic;

namespace Real_estate_market.Services.Database;

public partial class Advertise
{
    public int Id { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? UserId { get; set; }

    public int? PropertyId { get; set; }

    public virtual Property? Property { get; set; }

    public virtual User? User { get; set; }
}
