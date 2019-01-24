using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComiWeb.Pages.Product
{
    public class DetailModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public ComiCore.Model.Product Product { get; set; }
        public void OnGet(int id)
        {
            Product = _context.Products.Include(p => p.ProductDetails).Include(p => p.FlashSaleProducts).ThenInclude(f => f.FlashSale)
                .AsNoTracking().Select(p => new ComiCore.Model.Product {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    ProductDes = p.ProductDes,
                    ProductDetails = p.ProductDetails,
                    UnitPrice = p.UnitPrice,
                    FlashSaleProducts = p.FlashSaleProducts.Where(f => f.FlashSale.StartDate <= DateTime.Now && f.FlashSale.EndDate >= DateTime.Now).ToList()
                }).FirstOrDefault(p => p.Id == id);
        }
    }
}