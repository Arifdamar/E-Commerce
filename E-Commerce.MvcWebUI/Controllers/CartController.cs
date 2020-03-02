using E_Commerce.MvcWebUI.Entity;
using E_Commerce.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Cart
        public ActionResult Index()
        {
            return View(GetCart());
        }

        public ActionResult AddToCart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id);

            if (product != null)
            {
                GetCart().AddProduct(product);
            }

            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromCart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id);

            if (product != null)
            {
                GetCart().DeleteProduct(product);
            }

            return RedirectToAction("Index");
        }

        public Cart GetCart()
        {
            // Session is special for every user
            var cart = (Cart)Session["Cart"];

            // If the user doesn't have a cart, create a new cart and assign the cart to the user
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

        public PartialViewResult CartSummary()
        {
            return PartialView(GetCart());
        }

        public ActionResult Checkout()
        {
            return View(new ShippingDetails());
        }

        [HttpPost]
        public ActionResult Checkout(ShippingDetails entity)
        {
            var cart = GetCart();

            if (cart.cartLines.Count == 0)
            {
                ModelState.AddModelError("NoProductError", "There is no products in your cart.");
            }

            if (ModelState.IsValid)
            {
                SaveOrder(cart, entity);

                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(entity);
            }
            
        }

        private void SaveOrder(Cart cart, ShippingDetails entity)
        {
            var order = new Order();

            order.OrderNumber = "O" + (new Random()).Next(11111, 99999).ToString();
            order.Total = cart.TotalPrice();
            order.OrderDate = DateTime.Now;

            order.UserName = entity.UserName;
            order.AddressTitle = entity.AddressTitle;
            order.Address = entity.Address;
            order.City = entity.City;
            order.District = entity.District;
            order.Street = entity.Street;
            order.ZipCode = entity.ZipCode;

            order.OrderLines = new List<OrderLine>();

            foreach (var line in cart.cartLines)
            {
                OrderLine orderLine = new OrderLine();
                orderLine.Quantity = line.Quantity;
                orderLine.Price = line.Quantity * line.Product.Price;
                orderLine.ProductId = line.Product.Id;

                order.OrderLines.Add(orderLine);
                line.Product.Stock -= line.Quantity;
            }
            db.Orders.Add(order);
            db.SaveChanges();

        }
    }
}