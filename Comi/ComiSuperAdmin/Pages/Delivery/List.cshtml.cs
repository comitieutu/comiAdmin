using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComiSuperAdmin.Pages.Delivery
{
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ListModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<ComiCore.Model.Delivery> Deliveries { get; set; }
        public void OnGet()
        {
            Deliveries = _context.Deliveries.AsNoTracking().ToList();
        }
        public IActionResult OnGetDelete(int id)
        {
            var delivery = _context.Deliveries.FirstOrDefault(d => d.Id == id);
            delivery.Deleted = true;
            _context.SaveChanges();
            return RedirectToPage("/Delivery/List");
        }
    }
}