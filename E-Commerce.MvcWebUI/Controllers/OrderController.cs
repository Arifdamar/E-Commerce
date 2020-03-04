using E_Commerce.MvcWebUI.Entity;
using E_Commerce.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce.MvcWebUI.Controllers
{
    [Authorize(Roles = "admin")]
    public class OrderController : Controller
    {
        DataContext db = new DataContext();

        // GET: Order
        public ActionResult Index()
        {
            var orders = db.Orders.Select(i => new AdminOrderModel()
            {
                Id = i.Id,
                OrderNumber = i.OrderNumber,
                OrderDate = i.OrderDate,
                OrderState = i.OrderState,
                Total = i.Total,
                Count = i.OrderLines.Count
            }).OrderByDescending(i => i.OrderDate).ToList();

            return View(orders);
        }

        public ActionResult Details(int id)
        {
            var entity = db.Orders.Where(i => i.Id == id).Select(i => new OrderDetailsModel()
            {
                OrderId = i.Id,
                OrderNumber = i.OrderNumber,
                UserName = i.UserName,
                Total = i.Total,
                OrderDate = i.OrderDate,
                OrderState = i.OrderState,
                AddressTitle = i.AddressTitle,
                Address = i.Address,
                City = i.City,
                District = i.District,
                Street = i.Street,
                ZipCode = i.ZipCode,
                OrderLines = i.OrderLines.Select(j => new OrderLineModel()
                {
                    ProductId = j.ProductId,
                    ProductName = j.Product.Name.Length > 75 ? j.Product.Name.Substring(0, 72) + "..." : j.Product.Name,
                    Price = j.Price,
                    Image = j.Product.Image,
                    Quantity = j.Quantity
                }).ToList()
            }).FirstOrDefault();

            return View(entity);
        }

        public ActionResult UpdateOrderState(int OrderId, EnumOrderState orderState)
        {
            var order = db.Orders.FirstOrDefault(i => i.Id == OrderId);

            if(order != null)
            {
                order.OrderState = orderState;
                db.SaveChanges();

                TempData["message"] = "Updated";

                return RedirectToAction("Details", new { id = OrderId });
            }
            return RedirectToAction("Index");
        }

    }
}