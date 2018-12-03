using System;
using System.Collections.Generic;

namespace ComiCore.Model
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Country { get; set; }
        public int ProductId { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
