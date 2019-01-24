using ComiCore.Model;
using ComiCore.ViewModels;
using ComiService.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComiService.Service
{
    public static class CartService
    {
        public static void Buy(this ISession session, Product product, int quantity)
        {
            if (product != null)
            {
                if (SessionHelper.GetObjectFromJson<List<CartItem>>(session, "cart") == null)
                {
                    var cart = new List<CartItem>();
                    cart.Add(new CartItem()
                    {
                        Product = product,
                        Quantity = quantity
                    });
                    SessionHelper.SetObjectAsJson(session, "cart", cart);
                }
                else
                {
                    var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(session, "cart");
                    int index = Exists(cart, product.Id);
                    if (index == -1)
                    {
                        cart.Add(new CartItem()
                        {
                            Product = product,
                            Quantity = quantity
                        });
                    }
                    else
                    {
                        cart[index].Quantity += quantity;
                    }
                    SessionHelper.SetObjectAsJson(session, "cart", cart);
                }
            }
            else
            {
                SessionHelper.SetObjectAsJson(session, "cart", null);
            }
        }
        private static int Exists(List<CartItem> cart, int id)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
