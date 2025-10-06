using Microsoft.AspNetCore.Mvc;
using VanPhongPhamBackend.Data;
using VanPhongPhamBackend.Models;

namespace VanPhongPhamBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _context.Products.ToList();
            return Ok(list);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok(product);
        }
    }
}