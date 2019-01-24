using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComiSuperAdmin.Pages.Vendor
{
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ListModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<ComiCore.Model.Vendor> Vendors { get; set; }
        public void OnGet()
        {
            Vendors = _context.Vendors.AsNoTracking().Include(v => v.User).Include(v => v.Warehouse).Include(v => v.Bank).ToList();
        }
    }
}