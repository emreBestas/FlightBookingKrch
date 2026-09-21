using Microsoft.AspNetCore.Mvc;

namespace FlightBookingKrch.ViewComponents.DefaultViewComponents
{
    public class _DefaultDestinationOfferComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }   
    
    }
}
