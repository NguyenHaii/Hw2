using Microsoft.AspNetCore.Mvc;
using MvcProducts.Models;

namespace MvcProducts.Controllers
{
    public class ProductsController : Controller
    {
        // Dữ liệu mẫu
        private static readonly List<Product> _data = new()
        {
            new Product { Id = 1, Name = "Laptop Pro 14", Price = 32990_000m },
            new Product { Id = 2, Name = "Mechanical Keyboard", Price = 1590_000m },
            new Product { Id = 3, Name = "Wireless Mouse", Price = 690_000m }
        };

        // /Products
        public IActionResult Index()
        {
            return View(_data);
        }

        // /Products/Details/1
        public IActionResult Details(int id)
        {
            var p = _data.FirstOrDefault(x => x.Id == id);
            if (p == null) return NotFound();
            return View(p);
        }
    }
}
