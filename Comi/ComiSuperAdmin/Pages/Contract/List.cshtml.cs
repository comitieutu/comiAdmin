using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComiSuperAdmin.Pages.Contract
{
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ListModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<ComiCore.Model.Contract> Contracts { get; set; }
        public void OnGet()
        {
            Contracts = _context.Contracts.Include(c => c.Vendor).Include(c => c.Package).AsNoTracking().ToList();
        }
    }
}