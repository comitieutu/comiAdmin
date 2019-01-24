using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComiSuperAdmin.Pages.Delivery
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public CreateDeliveryMethod InputModel { get; set; }
        public class CreateDeliveryMethod
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public string Description { get; set; }
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var entry = _context.Add(new ComiCore.Model.Delivery());
            entry.CurrentValues.SetValues(InputModel);
            _context.SaveChanges();
            return RedirectToPage("/Delivery/List");
        }
    }
}