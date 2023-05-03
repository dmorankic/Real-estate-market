using System;

namespace Real_estate_market.model
{
    public partial class UserModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string Username { get; set; }
        

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateRegistered { get; set; }

        public string Gender { get; set; }

    }
}
