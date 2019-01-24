using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ComiSuperAdmin.Pages.User
{
    public class ListRoleModel : PageModel
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public ListRoleModel(RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public SelectList RoleItem { get; set; }
        [BindProperty]
        public ApplicationUser UserView { get; set; }
        [BindProperty]
        public string RoleId { get; set; }
        public void OnGet(string id)
        {
            RoleItem = new SelectList(_roleManager.Roles, "Id", "Name");
            UserView = _userManager.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role).FirstOrDefault(u => u.Id == id);
        }
        public async Task<IActionResult> OnGetDeleteAsync(string user, string role)
        {
            var usercur = _userManager.Users.Include(u => u.UserRoles).FirstOrDefault(u => u.Id == user);
            IdentityResult deletionResult = await _userManager.RemoveFromRoleAsync(usercur, role);
            return RedirectToPage("./ListRole", new { id = user });
        }
        public IActionResult OnPost()
        {
            var user = _userManager.Users.FirstOrDefault(u => u.Id == UserView.Id);
            var rolename = _roleManager.Roles.FirstOrDefault(r => r.Id == RoleId).Name;
            Task<IdentityResult> newUserRole = _userManager.AddToRoleAsync(user, rolename);
            newUserRole.Wait();
            return RedirectToPage("./ListRole", new { id = UserView.Id });
        }
    }
}