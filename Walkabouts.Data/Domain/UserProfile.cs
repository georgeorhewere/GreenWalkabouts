using System;
using System.Collections.Generic;
using System.Text;

namespace Walkabouts.Data.Domain
{
    public class UserProfile : BaseEntity
    {   
        public long UserId { get; set; }
        public AppUser AppUser { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }

    }
}
