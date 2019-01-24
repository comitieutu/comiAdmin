using ComiCore.Model;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ComiCore
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
