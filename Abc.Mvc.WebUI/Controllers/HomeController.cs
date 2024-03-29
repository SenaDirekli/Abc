﻿using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using Abc.Mvc.WebUI.Entity;
using Abc.Mvc.WebUI.Models;

namespace Abc.Mvc.WebUI.Controllers
{
    public class HomeController : Controller
    { 
        DataContext _context = new DataContext();

        public ActionResult ChangeCulture(string lang, string returnUrl)
        {
            Session["Culture"] = new CultureInfo(lang);
            return Redirect(returnUrl);
        }
        // GET: Home
        public ActionResult Index()
        {
            var urunler = _context.Products
                .Where(i => i.IsHome && i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name=i.Name.Length > 50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0,47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image,
                    CategoryId = i.CategoryId
                }).ToList();

            return View(urunler);
        }

        public ActionResult Details(int id)
        {
            return View(_context.Products.FirstOrDefault(i => i.Id==id));
        }

        public ActionResult List(int? id)
        {
            var urunler = _context.Products
                .Where(i => i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image ?? "resimsiz.jpg",
                    CategoryId = i.CategoryId
                }).AsQueryable();

            if (id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);
            }

            return View(urunler.ToList());
        }

        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Categories.ToList());
        }
    }
}