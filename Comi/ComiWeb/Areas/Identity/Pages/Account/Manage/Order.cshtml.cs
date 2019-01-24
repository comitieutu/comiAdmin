using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using ComiCore.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComiWeb.Areas.Identity.Pages.Account.Manage
{
    public class OrderModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public OrderModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IList<SaleOrder> SaleOrders { get; set; }
        public void OnGet()
        {
            SaleOrders = _context.SaleOrders.AsNoTracking().Where(s => s.UserId == _userManager.GetUserId(User)).ToList();
        }
    }
}