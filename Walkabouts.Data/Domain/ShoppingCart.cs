using System;
using System.Collections.Generic;
using System.Text;

namespace Walkabouts.Data.Domain
{
    public class ShoppingCart : BaseEntity
    {
        public long UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
        public ICollection<OrderItem> ShoppingCartItems { get; set; }
        public decimal CartTotal { get; set; }
        

    }
}
