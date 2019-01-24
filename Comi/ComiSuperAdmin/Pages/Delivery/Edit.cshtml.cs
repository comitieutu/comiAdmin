using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComiSuperAdmin.Pages.Delivery
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public ComiCore.Model.Delivery InputModel { get; set; }
        public void OnGet(int id)
        {
            InputModel = _context.Deliveries.FirstOrDefault(d => d.Id == id);
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Entry(InputModel).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToPage("/Delivery/List");
        }
    }
}