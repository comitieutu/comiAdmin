using Microsoft.AspNetCore.Identity;

namespace ComiCore
{
    public class ApplicationRole : IdentityRole
    {

        public ApplicationRole() : base() { }

        public ApplicationRole(string roleName) : base(roleName) { }

        public ApplicationRole(string roleName, string description) : base(roleName)
        {
            base.Name = roleName;
            this.Description = description;
        }

        public string Description { get; set; }

    }
}
