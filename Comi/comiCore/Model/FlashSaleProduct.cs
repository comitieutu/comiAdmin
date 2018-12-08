using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class FlashSaleProduct : BaseEntity
    {
        public int ProductId { get; set; }
        public int FlashSaleId { get; set; }
        public string Description { get; set; }
        public int Sale { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<FlashSale> FlashSales { get; set; }
    }
}
