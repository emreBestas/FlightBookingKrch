using Microsoft.AspNetCore.Mvc;

namespace FlightBookingKrch.Areas.Admin.ViewComponents
{
    public class _AdminSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
        