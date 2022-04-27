using System.Linq;
using Espadon.Database;
using Microsoft.AspNetCore.Mvc;

namespace Espadon.VievComponents
{
    public class RoomViewComponent : ViewComponent
    {
        private AppDbContext _context;

        public RoomViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var chats = _context.Chats.ToList();
            return View();
        }
    }
}
