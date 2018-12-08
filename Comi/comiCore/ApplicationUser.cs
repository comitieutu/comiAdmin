using ComiCore.Model;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ComiCore
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
