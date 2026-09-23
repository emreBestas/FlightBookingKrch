using FlightBookingKrch.Dtos.BookingDtos;

namespace FlightBookingKrch.Services.BookingServices
{
    public interface IBookingService
    {
        Task CreateBookingAsync(CreateBookingDto dto);
    }
}
