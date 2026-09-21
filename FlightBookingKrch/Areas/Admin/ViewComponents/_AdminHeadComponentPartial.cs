using Microsoft.AspNetCore.Mvc;

namespace FlightBookingKrch.Areas.Admin.ViewComponents
{
    public class _AdminHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
