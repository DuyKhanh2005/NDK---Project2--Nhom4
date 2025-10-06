using Microsoft.AspNetCore.Mvc;
using VanPhongPhamBackend.Data;
using VanPhongPhamBackend.Models;

namespace VanPhongPhamBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            if (_context.Users.Any(u => u.Email == user.Email))
                return BadRequest("Email đã tồn tại");

            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok("Đăng ký thành công");
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User login)
        {
            var user = _context.Users
                .SingleOrDefault(u => u.Email == login.Email && u.Password == login.Password);
            if (user == null) return Unauthorized("Sai thông tin đăng nhập");
            return Ok(new { user.Id, user.FullName, user.Email });
        }
    }
}