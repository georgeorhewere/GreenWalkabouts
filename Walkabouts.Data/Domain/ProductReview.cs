using System;
using System.Collections.Generic;
using System.Text;

namespace Walkabouts.Data.Domain
{
    public class ProductReview : BaseEntity
    {
        public string ReviewBy { get; set; }
        public string Comment { get; set; }
        public int NumOfStars { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
