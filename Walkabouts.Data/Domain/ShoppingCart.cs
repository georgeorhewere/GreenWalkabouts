using System;
using System.Collections.Generic;
using System.Text;

namespace Walkabouts.Data.Domain
{
    public class ShoppingCart : BaseEntity
    {
        public int UserProfileId { get; set; }
        public List<OrderItem> ShoppingCartItems { get; set; }
        public decimal CartTotal { get; set; }
        

    }
}
