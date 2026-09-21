using Microsoft.AspNetCore.Mvc;

namespace FlightBookingKrch.ViewComponents.BookingViewComponents
{
    public class _BookingAreaComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
