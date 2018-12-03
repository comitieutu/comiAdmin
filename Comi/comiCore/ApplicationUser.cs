using ComiCore.Model;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ComiCore
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
