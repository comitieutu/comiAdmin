using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComiSuperAdmin.Pages.SaleOrder
{
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ListModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<ComiCore.Model.SaleOrder> SaleOrders { get; set; }
        public void OnGet()
        {
            SaleOrders = _context.SaleOrders
                .Include(s => s.ApplicationUser).Include(s => s.Payment).Include(s => s.Delivery)
                .AsNoTracking().ToList();
        }
        public void OnGetDelete(int id)
        {
            var saleOrder = _context.SaleOrders.FirstOrDefault(s => s.Id == id);
            saleOrder.Deleted = true;
            _context.SaveChanges();
        }
    }
}