using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using ComiCore.Model;
using ComiService.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComiWeb.Pages.Cart
{
    public class DeliveryMethodModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeliveryMethodModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<Delivery> Deliveries { get; set; }
        [BindProperty]
        public int DeliveryId { get; set; }
        public void OnGet()
        {
            Deliveries = _context.Deliveries.AsNoTracking().ToList();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "delivery", DeliveryId);
            return RedirectToPage("/Cart/PaymentMethod");
        }
    }
}