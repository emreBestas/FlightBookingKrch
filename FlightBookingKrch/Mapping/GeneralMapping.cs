using AutoMapper;
using FlightBookingKrch.Dtos.FlightDtos;
using FlightBookingKrch.Entities;

namespace FlightBookingKrch.Mapping
{
    public class GeneralMapping: Profile
    {
        public GeneralMapping()
        {
            CreateMap<Flight, CreateFlightDto>().ReverseMap();
            CreateMap<Flight, UpdateFlightDto>().ReverseMap();
            CreateMap<Flight, GetFlightByIdDto>().ReverseMap();
            CreateMap<Flight, ResultFlightDto>().ReverseMap();
        }
    }
}
