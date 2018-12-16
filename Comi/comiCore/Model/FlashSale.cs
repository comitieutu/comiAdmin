using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class FlashSale : BaseEntity
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public int Sale { get; set; }
        public string Image { get; set; }
    }
}
