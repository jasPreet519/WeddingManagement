using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeddingManagement.Data;

namespace WeddingManagement.Controllers
{
    public class BookedEventsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public BookedEventsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var BookedEvents = await _context.BookedEvents.ToListAsync();
            return View(BookedEvents);
        }
    }
}
