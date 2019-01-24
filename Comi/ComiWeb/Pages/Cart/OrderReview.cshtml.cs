using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using ComiCore.ViewModels;
using ComiService.Helpers;
using ComiService.Paypal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace ComiWeb.Pages.Cart
{
    public class OrderReviewModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public OrderReviewModel(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public IList<CartItem> Items { get; set; }
        public void OnGet()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                Items = cart;
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "payment", "Cash");
        }
        public void OnGetPaypal()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                Items = cart;
            }
            var result = PDTHolder.Success(Request.Query["tx"].ToString(), _configuration);
            if (result != null)
            {
                SessionHelper.SetObjectAsJson(HttpContext.Session, "payment", "PayPal");
            }
        }
    }
}