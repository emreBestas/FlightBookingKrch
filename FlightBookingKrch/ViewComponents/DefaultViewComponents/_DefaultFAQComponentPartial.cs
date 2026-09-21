using Microsoft.AspNetCore.Mvc;

namespace FlightBookingKrch.ViewComponents.DefaultViewComponents
{
    public class _DefaultFAQComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }   
    
    }
}
