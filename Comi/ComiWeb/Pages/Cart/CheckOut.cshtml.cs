using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComiCore;
using ComiCore.Model;
using ComiCore.ViewModels;
using ComiService.Common;
using ComiService.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComiWeb.Pages.Cart
{
    public class CheckOutModel : AddressInfoPageModel
    {
        private readonly ApplicationDbContext _context;

        public CheckOutModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public ReceiveProductViewModel InputReceiveProductViewModel { get; set; }
        [BindProperty]
        public SaleOrderViewModel InputSaleOrderViewModel { get; set; }
        public IList<Payment> Payments { get; set; }
        public IList<Delivery> Deliveries { get; set; }
        public IList<CartItem> Items { get; set; }
        public class ReceiveProductViewModel
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string ShipToAddress { get; set; }
            public string ShipToStreet { get; set; }
            public string ShipToDistrict { get; set; }
            public string ShipToCity { get; set; }
            public string ShipToCountry { get; set; }
        }
        public class SaleOrderViewModel
        {
            public string UserId { get; set; }
            public bool OrderStatus { get; set; }
            public double TotalPrice { get; set; }
            public DateTime ShippedDate { get; set; }
            public int ShipperId { get; set; }
            public int PaymentId { get; set; }
            public int DeliveryId { get; set; }
        }
        public void OnGet()
        {
            DistrictDropDownList(_context);
            StateOrProvinceDropDownList(_context);
            CountryDropDownList(_context);
            Payments = _context.Payments.AsNoTracking().ToList();
            Deliveries = _context.Deliveries.AsNoTracking().ToList();
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                Items = cart;
            }
        }


        public IActionResult OnPost()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");

            var entryReceiveProduct = _context.Add(new ReceiveProduct());
            entryReceiveProduct.CurrentValues.SetValues(InputReceiveProductViewModel);

            var saleOrderDetails = new List<SaleOrderDetail>();
            cart.ForEach(i => saleOrderDetails.Add(
                    new SaleOrderDetail
                    {
                        Product = i.Product,
                        Quantity = i.Quantity,
                        UnitPrice = i.Product.UnitPrice
                    }
                ));

            _context.SaveChanges();
            return RedirectToPage("/Cart/Success");
        }


    }
}