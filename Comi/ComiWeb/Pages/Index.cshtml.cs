using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComiWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<ComiCore.Model.Product> BestSellers { get; set; }
        public IList<ComiCore.Model.Product> Newests { get; set; }
        public void OnGet()
        {
            //BestSellers
            //_context.SaleOrderDetails.AsNoTracking().Where(s => s.CreatedDate >= (DateTime.Now - TimeSpan.FromDays(7)) && s.CreatedDate <= DateTime.Now)
            //    .GroupBy(s => s.ProductId)
            //    .Select(s => new { s.FirstOrDefault().ProductId, Quantity = s.Sum(p => p.Quantity) })
            //    .OrderByDescending(s => s.Quantity).Take(7).ToList()
            //    .ForEach(p => BestSellers.Add(_context.Products.Include(b => b.ProductDetails)
            //        .Select(b => new ComiCore.Model.Product
            //        {
            //            Id = b.Id,
            //            ProductName = b.ProductName,
            //            ProductDes = b.ProductDes,
            //            UnitPrice = b.UnitPrice,
            //            ProductDetails = b.ProductDetails.Select(d => new ComiCore.Model.ProductDetail { ProductImage = d.ProductImage }).ToList()
            //        }).FirstOrDefault(i => i.Id == p.ProductId)
            //        ));
            ////Newests
            //Newests = _context.Products.AsNoTracking().OrderByDescending(p => p.CreatedDate).Take(7).ToList();
        }
    }
}
