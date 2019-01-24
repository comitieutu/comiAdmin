using ComiCore;
using ComiCore.ViewModels;
using ComiService.Helpers;
using ComiService.Paypal;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace ComiWeb.Pages.Cart
{
    public class PaymentMethodModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public PaymentMethodModel(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public PayPalConfig PayPalConfig { get; set; }
        public IList<CartItem> CartItems { get; set; }
        public void OnGet()
        {
            PayPalConfig = PayPalService.GetPayPalConfig(_configuration);
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                CartItems = cart;
            }
        }
    }
}