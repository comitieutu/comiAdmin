using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class Bank : BaseEntity
    {
        public string BankAccount { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
