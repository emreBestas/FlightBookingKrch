using FlightBookingKrch.Services.OverBookingNoShowServices;
using Microsoft.AspNetCore.Mvc;

namespace FlightBookingKrch.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OverbookingForecastController : Controller
    {
        private readonly NoShowPredictionService _predictionService;

        public OverbookingForecastController(NoShowPredictionService predictionService)
        {
            _predictionService = predictionService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _predictionService.PredictJanuary2027Async();
            return View(values);
        }
    }
}
