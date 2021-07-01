using System;
using System.Collections.Generic;
using System.Text;

namespace Walkabouts.Services.DTO
{
    public class CatalogItemDTO : Services.DTO.BaseDTO
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockLevel { get; set; }
        public bool Featured { get; set; }
    }
}
