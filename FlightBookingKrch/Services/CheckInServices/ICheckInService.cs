using FlightBookingKrch.Dtos.CheckInDtos;

namespace FlightBookingKrch.Services.CheckInServices
{
    public interface ICheckInService
    {
        Task CompleteCheckInAsync(CompleteCheckInDto dto);
    }
}
