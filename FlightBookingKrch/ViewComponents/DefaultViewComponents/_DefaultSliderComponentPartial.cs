using Microsoft.AspNetCore.Mvc;

namespace FlightBookingKrch.ViewComponents.DefaultViewComponents
{
    public class _DefaultSliderComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }

    }
}
