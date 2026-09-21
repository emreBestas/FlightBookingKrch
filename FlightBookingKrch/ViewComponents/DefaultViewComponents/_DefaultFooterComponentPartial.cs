using Microsoft.AspNetCore.Mvc;

namespace FlightBookingKrch.ViewComponents.DefaultViewComponents
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }   
    
    }
}
