using Microsoft.AspNetCore.Mvc;
using WebCandleShopNet7.Data;
using WebCandleShopNet7.Models;

namespace WebCandleShopNet7.Controllers
{
    public class HomePageController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HomePageController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            IEnumerable<Candle> objCategoryCanles = _db.Candles;
            return View(objCategoryCanles);
        }
    }

}