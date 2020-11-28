using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Walkabouts.Data.Domain
{
    public class BaseEntity : IRefEntity
    {
        public BaseEntity()
        {
            RefId = Guid.NewGuid();
            CreatedOn = DateTime.Now;
        }
        
        public long CreatedBy { set; get; }
        public DateTime CreatedOn { set; get; }
        public long? ModifiedBy { set; get; }
        public DateTime? ModifiedOn { set; get; }
        public Guid RefId { get; set; }
    }
}
