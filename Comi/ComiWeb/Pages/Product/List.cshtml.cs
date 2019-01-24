using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using ComiService.Helpers;
using ComiService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComiWeb.Pages.Product
{
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ListModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<ComiCore.Model.Product> Products { get; set; }
        public async Task OnGetAsync(int id, string currentFilter, string searchString, int? pageIndex)
        {
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            var products = _context.Products.AsQueryable();
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.ProductName.Contains(searchString));
            }
            else
            {
                products = products.Where(p => p.CategoryId == id);
            }
            products = products.Include(p => p.ProductDetails).Include(p => p.FlashSaleProducts)
                .ThenInclude(f => f.FlashSale).AsNoTracking()
                .Select(p => new ComiCore.Model.Product
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    ProductDetails = p.ProductDetails,
                    UnitPrice = p.UnitPrice,
                    FlashSaleProducts = p.FlashSaleProducts.Where(f => f.FlashSale.StartDate <= DateTime.Now && f.FlashSale.EndDate >= DateTime.Now).ToList()
                });

            int pageSize = 3;
            Products = await PaginatedList<ComiCore.Model.Product>.CreateAsync(products, pageIndex ?? 1, pageSize);
        }
        public IActionResult Auto(string term)
        {
            List<string> name = _context.Products.Where(p => p.ProductName.Contains(term)).Select(p => p.ProductName).ToList();
            return new JsonResult(name);
        }
    }
}