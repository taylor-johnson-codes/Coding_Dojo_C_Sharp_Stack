using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Products_and_Categories.Models;

namespace Products_and_Categories.Controllers
{
    public class HomeController : Controller
    {
        private MyContext db;
        public HomeController(MyContext context)
        {
        db = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Products");
        }

        [HttpGet("products")]
        public IActionResult Products()
        {
            List<Product> products = db.Products.ToList();
            ViewBag.Products1 = products;
            return View("Products");
        }

        [HttpPost("products/create")]
        public IActionResult CreateProduct(Product newProduct)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(newProduct);
                db.SaveChanges();
                return RedirectToAction("Products");
            }
            return View("Products");
        }

        [HttpGet("products/{productId}")]
        public IActionResult Product(int productId)
        {
            Product product = db.Products
                .Include(prod => prod.Categories)
                .ThenInclude(assoc => assoc.CategoryOfProduct)
                .FirstOrDefault(prod => prod.ProductId == productId);

            List<Category> cat = db.Categories
                .Where(cat => cat.Products.Any(prod => prod.ProductId == productId) == false)
                .ToList();
            ViewBag.Categories1 = cat;

            return View("Product", product);
        }

        [HttpPost("products/{productId}/add_category")]
        public IActionResult AddCategoryToProduct(int productId, int categoryId, Association newAssociation)
        {
            newAssociation.ProductId = productId;
            newAssociation.CategoryId = categoryId;
            db.Associations.Add(newAssociation);
            db.SaveChanges();
            return RedirectToAction("Product", productId);
        }

        [HttpGet("categories")]
        public IActionResult Categories()
        {
            List<Category> cat = db.Categories.ToList();
            ViewBag.Categories2 = cat;
            return View("Categories");
        }

        [HttpPost("categories/create")]
        public IActionResult CreateCategory(Category newCategory)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(newCategory);
                db.SaveChanges();
                return RedirectToAction("Categories");
            }
            return View("Categories");
        }

        [HttpGet("categories/{categoryId}")]
        public IActionResult Category(int categoryId)
        {
            Category category = db.Categories
                .Include(cat => cat.Products)
                .ThenInclude(assoc => assoc.ProductInCategory)
                .FirstOrDefault(cat => cat.CategoryId == categoryId);

            List<Product> products = db.Products
                .Include(prod => prod.Categories)
                .Where(prod => prod.Categories.Any(cat => cat.CategoryId == categoryId) == false)
                .ToList();

            ViewBag.Products2 = products;
            return View("Category", category);
        }

        [HttpPost("categories/{categoryId}/add_product")]
        public IActionResult AddProductToCategory(int productId, int categoryId, Association newAssociation)
        {
            newAssociation.ProductId = productId;
            newAssociation.CategoryId = categoryId;
            db.Associations.Add(newAssociation);
            db.SaveChanges();
            return RedirectToAction("Category", categoryId);
        }
    }
}