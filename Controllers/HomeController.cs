using Espadon.Database;
using Espadon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Espadon.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context) => _context = context;
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{id}")]
        public IActionResult Chat(int id)
        {
            var chat = _context.Chats.FirstOrDefault(x => x.Id == id);
            return View(chat);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom(string name)
        {
            _context.Chats.Add(new Chat
            {
                Name = name,
                Type = ChatType.Room
            });

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}