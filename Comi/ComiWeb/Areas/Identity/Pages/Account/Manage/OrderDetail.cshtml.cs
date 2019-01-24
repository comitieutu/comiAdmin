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
    public class OrderDetailModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public OrderDetailModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public SaleOrder SaleOrder { get; set; }
        public void OnGet(int id)
        {
            SaleOrder = _context.SaleOrders.AsNoTracking().Include(s => s.SaleOrderDetails)
                .ThenInclude(d => d.Product).ThenInclude(p => p.ProductDetails)
                .Include(s => s.ReceiveProduct).ThenInclude(r => r.District).ThenInclude(d => d.StateOrProvince).ThenInclude(s => s.Country)
                .FirstOrDefault(s => s.Id == id);
        }
    }
}