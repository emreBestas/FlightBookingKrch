using Microsoft.AspNetCore.Mvc;

namespace FlightBookingKrch.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FlightsController : Controller
    {
        public IActionResult FlightList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateFlight()
        {
            return View();
        }
    }
}
