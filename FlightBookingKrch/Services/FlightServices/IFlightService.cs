using FlightBookingKrch.Dtos.FlightDtos;
using FlightBookingKrch.Dtos.PassengerDtos;

namespace FlightBookingKrch.Services.FlightServices
{
    public interface IFlightService
    {
        Task<List<ResultFlightDto>> GetAllFlightsAsync();
        Task<GetFlightByIdDto> GetFlightByIdAsync(string id);
        Task CreateFlightAsync(CreateFlightDto createFlightDto);
        Task DeleteFlightAsync(string id);
        Task<List<PassengerListItemDto>> GetPassengersDetailsWithPassengers(string id);
    }
}
