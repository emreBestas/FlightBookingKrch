using Microsoft.AspNetCore.Mvc;

namespace FlightBookingKrch.ViewComponents.DefaultViewComponents
{
    public class _DefaultServiceComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    
    }
}
