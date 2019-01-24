using ComiCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.ViewModels
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
