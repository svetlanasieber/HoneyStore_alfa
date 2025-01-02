using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;

public class ProductController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProductController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var products = _context.Products.ToList();
        return View(products);
    }

    public IActionResult Details(int id)
    {
        var product = _context.Products.Find(id);
        if (product == null) return NotFound();
        return View(product);
    }
}

