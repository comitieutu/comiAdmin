using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using ComiCore.ViewModels;
using ComiService.Helpers;
using ComiService.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComiWeb.Pages.Cart
{
    public class ShoppingCartModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public int[] Quantity { get; set; }
        public IList<CartItem> Items { get; set; }
        public List<ComiCore.Model.Product> NewestProducts { get; set; }
        public void OnGet()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                Items = cart;
            }
            NewestProducts = _context.Products.AsNoTracking().Include(p => p.ProductDetails).OrderByDescending(p => p.CreatedDate)
                .Select(p => new ComiCore.Model.Product
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    ProductDetails = p.ProductDetails.Select(d => new ComiCore.Model.ProductDetail { ProductImage = d.ProductImage }).Take(2).ToList(),
                    UnitPrice = p.UnitPrice
                }).Take(3).ToList();
        }
        public IActionResult OnGetBuy(int id, int quantity)
        {
            var product = _context.Products.Include(p => p.ProductDetails).Include(p => p.FlashSaleProducts).ThenInclude(f => f.FlashSale)
                .AsNoTracking()
                .Select(p => new ComiCore.Model.Product {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    ProductDetails = p.ProductDetails.Select(d => new ComiCore.Model.ProductDetail { ProductImage = d.ProductImage}).ToList(),
                    UnitPrice = p.FlashSaleProducts.Count != 0 ? (p.UnitPrice * p.FlashSaleProducts.FirstOrDefault().FlashSale.Sale / 100) : p.UnitPrice
                }).FirstOrDefault(p => p.Id == id);
            CartService.Buy(HttpContext.Session, product, quantity);
            return new EmptyResult();
        }
        public IActionResult OnGetRemove(int id)
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            cart.Remove(cart.FirstOrDefault(i => i.Product.Id == id));
            if (cart.Count == 0)
            {
                cart = null;
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("./ShoppingCart");
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count(); i++)
            {
                cart[i].Quantity = Quantity[i];
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("./ShoppingCart");
        }
    }
}