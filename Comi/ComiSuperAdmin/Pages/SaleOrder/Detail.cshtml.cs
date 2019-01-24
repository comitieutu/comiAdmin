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
    public class DetailModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<ComiCore.Model.SaleOrderDetail> SaleOrderDetails { get; set; }
        public void OnGet(int id)
        {
            SaleOrderDetails = _context.SaleOrderDetails.Include(d => d.Product).Where(d => d.SaleOrderId == id).ToList();

        }
    }
}