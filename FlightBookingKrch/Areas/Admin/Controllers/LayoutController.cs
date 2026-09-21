using Microsoft.AspNetCore.Mvc;

namespace FlightBookingKrch.Areas.Admin.Controllers
{
    public class LayoutController : Controller
    {
        [Area("Admin")]
        public IActionResult AdminLayout()
        {
            return View();
        }
    }
}
