using Microsoft.AspNetCore.Mvc;

namespace FlightBookingKrch.Areas.Admin.ViewComponents
{
    public class _AdminTopbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }   
    
    }
}
