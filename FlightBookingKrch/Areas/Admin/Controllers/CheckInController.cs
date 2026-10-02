using Microsoft.AspNetCore.Mvc;

namespace FlightBookingKrch.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CheckInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
