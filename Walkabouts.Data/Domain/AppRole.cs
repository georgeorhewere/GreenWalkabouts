using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Walkabouts.Data.Domain
{
    public class AppRole : IdentityRole<long>, IRefEntity
    {
        public AppRole()
        {
            RefId = Guid.NewGuid();
        }
        public Guid RefId { get; set; }
    }
}
