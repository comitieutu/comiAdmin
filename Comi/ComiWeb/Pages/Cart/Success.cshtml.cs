using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ComiCore;
using ComiCore.Model;
using ComiCore.ViewModels;
using ComiService.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComiWeb.Pages.Cart
{
    public class SuccessModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _contextAccessor;

        public SuccessModel(ApplicationDbContext context, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _contextAccessor = contextAccessor;
        }
        public void OnGet()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            var userId = _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var receiveProduct = SessionHelper.GetObjectFromJson<ReceiveProduct>(HttpContext.Session, "address");

            var saleOrderDetails = new List<SaleOrderDetail>();
            cart.ForEach(i => saleOrderDetails.Add(
                    new SaleOrderDetail
                    {
                        Product = i.Product,
                        Quantity = i.Quantity,
                        UnitPrice = i.Product.UnitPrice
                    }
                ));

            ComiCore.Model.Product product = new ComiCore.Model.Product();
            cart.ForEach(i =>
            {
                product = _context.Products.FirstOrDefault(p => p.Id == i.Product.Id);
                product.Quantity -= i.Quantity;
            });

            var saleOrder = new SaleOrder {
                UserId = userId,
                DeliveryPrice = _context.Deliveries.FirstOrDefault(d => d.Id == SessionHelper.GetObjectFromJson<int>(HttpContext.Session, "delivery")).Price,
                TotalPrice = cart.Sum(i => i.Product.UnitPrice * i.Quantity) + _context.Deliveries.FirstOrDefault(d => d.Id == SessionHelper.GetObjectFromJson<int>(HttpContext.Session, "delivery")).Price,
                DeliveryId = SessionHelper.GetObjectFromJson<int>(HttpContext.Session, "delivery"),
                PaymentId = _context.Payments.Where(p => p.Name == SessionHelper.GetObjectFromJson<string>(HttpContext.Session, "payment")).FirstOrDefault().Id,
                SaleOrderDetails = saleOrderDetails
            };
            _context.SaleOrders.Add(saleOrder);
            receiveProduct.SaleOrder = saleOrder;
            _context.ReceiveProducts.Add(receiveProduct);
            _context.SaveChanges();

            //huy session
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", null);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "address", null);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "delivery", null);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "payment", null);
        }
    }
}