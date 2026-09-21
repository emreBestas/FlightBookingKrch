using Microsoft.AspNetCore.Mvc;

namespace FlightBookingKrch.ViewComponents.BookingViewComponents
{
    public class _BookingTagsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }   
    }
}
