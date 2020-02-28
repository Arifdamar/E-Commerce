using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Commerce.MvcWebUI.Entity;
using E_Commerce.MvcWebUI.Models;

namespace E_Commerce.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            return View(_context.Products
                .Where(i => i.IsHome && i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 90 ? i.Name.Substring(0, 87) + "..." : i.Name,
                    Description = i.Description.Length > 200 ? i.Description.Substring(0, 197) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image,
                    CategoryId = i.CategoryId
                }).ToList());
        }

        public ActionResult Details(int id)
        {
            return View(_context.Products.FirstOrDefault(i => i.Id == id));
        }

        public ActionResult List(int? id)
        {
            var products = _context.Products
                .Where(i => i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 100 ? i.Name.Substring(0, 97) + "..." : i.Name,
                    Description = i.Description.Length > 200 ? i.Description.Substring(0, 197) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image,
                    CategoryId = i.CategoryId
                }).AsQueryable();

            if (id!=null)
            {
                products = products.Where(i => i.CategoryId == id);
            }

            return View(products.ToList());
        }

        public PartialViewResult _GetCategories()
        {
            return PartialView(_context.Categories.ToList());
        }
    }
}