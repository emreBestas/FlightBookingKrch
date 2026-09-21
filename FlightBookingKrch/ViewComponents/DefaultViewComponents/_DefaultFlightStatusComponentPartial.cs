using Microsoft.AspNetCore.Mvc;

namespace FlightBookingKrch.ViewComponents.DefaultViewComponents
{
    public class _DefaultFlightStatusComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
