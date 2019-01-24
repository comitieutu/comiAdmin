using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ComiSuperAdmin.Pages.SaleOrder
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public ComiCore.Model.SaleOrder SaleOrder { get; set; }
        public SelectList Shippers { get; set; }
        public void OnGet(int id)
        {
            SaleOrder = _context.SaleOrders.FirstOrDefault(s => s.Id == id);
            Shippers = new SelectList(_context.Shippers.AsNoTracking(), "Id", "ContactName", SaleOrder.ShipperId);
        }
        public IActionResult OnPost()
        {
            _context.Entry(SaleOrder).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToPage("/SaleOrder/List");
        }
    }
}