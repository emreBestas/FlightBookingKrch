using Microsoft.AspNetCore.Mvc;

namespace FlightBookingKrch.ViewComponents.DefaultViewComponents
{
    public class _DefaultScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
