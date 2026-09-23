using FlightBookingKrch.Dtos.PassengerDtos;

namespace FlightBookingKrch.Dtos.BookingDtos
{
    public class CreateBookingDto
    {
        public string FlightId { get; set; }
        public List<CreatePassergerDto> Passengers { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string PnrNumber { get; set; }
    }
}
