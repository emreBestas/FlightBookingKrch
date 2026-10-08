using FlightBookingKrch.MachineLearningModels;
using FlightBookingKrch.Services.MachineLearningServices;
using FlightBookingKrch.Services.NoShowServices;
using Microsoft.AspNetCore.Mvc;

namespace FlightBookingKrch.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ForecastController : Controller
    {
        private readonly MongoFlightDataService _mongoFlightDataService;
        private readonly FlightMlService _flightMlService;
        private readonly NoShowService noShowService;
        [HttpGet]
        public async Task<IActionResult> NoShowAnalysis()
        {
            var values= await noShowService.GetSlotBasedNoShowRatesAsync();
            return View (values);
        }

        public ForecastController(MongoFlightDataService mongoFlightDataService, FlightMlService flightMlService, NoShowService noShowService)
        {
            _mongoFlightDataService = mongoFlightDataService;
            _flightMlService = flightMlService;
            this.noShowService = noShowService;
        }

        public async Task<IActionResult> TrainModel()
        {
            var mlData = await _mongoFlightDataService.ConvertToMlDataAsync();
            _flightMlService.Train(mlData);
            ViewBag.Message = "Model başarıyla eğitildi.";
            return View();
        }
        public IActionResult Predict()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Predict(DateTime flightDate, string flightType)
        {
            var input = new FlightData
            {
                Month = flightDate.Month,

                DayOfWeek = (float)flightDate.DayOfWeek,

                FlightType = flightType == "Morning" ? 0 : 1
            };

            var prediction = _flightMlService.Predict(input);

            ViewBag.Result = prediction.PredictedLabel
                ? "Bu uçuş büyük ihtimal dolacaktır."
                : "Bu uçuşta yoğunluk düşük görünüyor.";

            ViewBag.Probability = prediction.Probability;

            return View();
        }
    }
}
    