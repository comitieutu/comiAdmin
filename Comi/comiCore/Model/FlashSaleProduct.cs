using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class FlashSaleProduct : BaseEntity
    {
        public int ProductId { get; set; }
        public int FlashSaleId { get; set; }
        public virtual Product Product { get; set; }
        public virtual FlashSale FlashSale { get; set; }
    }
}
