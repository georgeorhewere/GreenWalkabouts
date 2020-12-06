using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Walkabouts.Data.Domain
{
    public class AppUser : IdentityUser<long>, IRefEntity
    {
        public AppUser()
        {
            RefId = Guid.NewGuid();
            CreatedOn = DateTime.Now;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public DateTime CreatedOn { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? ModifiedOn { set; get; }
        public bool IsDeleted { get; set; }
        public Guid RefId { get; set; }
        public UserProfile UserProfile { get; set; }        
    }
}
