﻿using System.Collections.Generic;

namespace Walkabouts.Data.Domain
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockLevel { get; set; }
        public bool Featured { get; set; }
        public ICollection<ProductReview> Reviews { get; set; }
    }
}