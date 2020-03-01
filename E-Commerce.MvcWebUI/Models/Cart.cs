using E_Commerce.MvcWebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.MvcWebUI.Models
{
    public class Cart
    {
        private List<CartLine> _cartLines = new List<CartLine>();
        public List<CartLine> cartLines { get { return _cartLines; } }


        public void AddProduct(Product product, int quantity=1)
        {
            var line = _cartLines.FirstOrDefault(i => i.Product.Id == product.Id);
            if (line == null)
            {
                _cartLines.Add(new CartLine() { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void DeleteProduct(Product product)
        {
            _cartLines.RemoveAll(i => i.Product.Id == product.Id);
        }

        public double TotalPrice()
        {
            /* My first solution
            double totalPrice = 0;
            foreach (var item in _cartLines)
            {
                totalPrice += item.Product.Price * item.Quantity;
            }

            return totalPrice;
            */

            // The better solution
            return _cartLines.Sum(i => i.Product.Price * i.Quantity);
        }

        public void Clear()
        {
            _cartLines.Clear();
        }
    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}