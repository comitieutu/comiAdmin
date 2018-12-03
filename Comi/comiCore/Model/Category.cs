using System.Collections.Generic;

namespace ComiCore.Model
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string CategoryDes { get; set; }
        public int Parent { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
