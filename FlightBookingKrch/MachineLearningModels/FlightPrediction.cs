using System.Security.Principal;

namespace FlightBookingKrch.MachineLearningModels
{
    public class FlightPrediction
    {
        public bool PredictedLabel { get; set; }
        public float Probability { get; set; }
        public float Score { get; set; }
    }
}
