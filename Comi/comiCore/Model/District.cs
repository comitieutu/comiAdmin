using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class District : BaseEntity
    {
        public int StateOrProvinceId { get; set; }

        public virtual StateOrProvince StateOrProvince { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }

        public string Location { get; set; }
        public virtual ICollection<ReceiveProduct> ReceiveProducts { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}
