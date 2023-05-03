using System;
using System.Collections.Generic;

namespace Real_estate_market.Services.Database;

public partial class User
{
    public int Id { get; set; }

    public string? FirstName { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public DateTime? DateRegistered { get; set; }

    public string? Gender { get; set; }

}
