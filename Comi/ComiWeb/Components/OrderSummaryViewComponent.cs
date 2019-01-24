using ComiCore;
using ComiCore.ViewModels;
using ComiService.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComiWeb.Components
{
    public class OrderSummaryViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public OrderSummaryViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            var deliveryId = SessionHelper.GetObjectFromJson<int?>(HttpContext.Session, "delivery");

            ViewBag.SubTotal = cart.Sum(i => i.Product.UnitPrice * i.Quantity);
            if (deliveryId != null)
            {
                ViewBag.ShippingPrice = _context.Deliveries.AsNoTracking().FirstOrDefault(d => d.Id == deliveryId).Price;
                ViewBag.Total = cart.Sum(i => i.Product.UnitPrice * i.Quantity) + _context.Deliveries.AsNoTracking().FirstOrDefault(d => d.Id == deliveryId).Price;
            }
            else
            {
                ViewBag.ShippingPrice = 0;
                ViewBag.Total = cart.Sum(i => i.Product.UnitPrice * i.Quantity);
            }
            return View();
        }
    }
}
