using AutoMapper;
using FlightBookingKrch.Dtos.FlightDtos;
using FlightBookingKrch.Entities;
using FlightBookingKrch.Settings;
using MongoDB.Driver;

namespace FlightBookingKrch.Services.FlightServices
{
    public class FlightService : IFlightService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Flight> _flightCollection;
        public FlightService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            _mapper = mapper;
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _flightCollection = database.GetCollection<Flight>(_databaseSettings.FlightCollectionName);
        }

    

        public async Task CreateFlightAsync(CreateFlightDto createFlightDto)
        {
            var values = _mapper.Map<Flight>(createFlightDto);
            await _flightCollection.InsertOneAsync(values);
        }       

        public async Task DeleteFlightAsync(string id)
        {
            await _flightCollection.DeleteOneAsync(x => x.FlightId == id);
        }

        public async Task<List<ResultFlightDto>> GetAllFlightsAsync()
        {
            var values = await _flightCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultFlightDto>>(values);
        }

        public async Task<GetFlightByIdDto> GetFlightByIdAsync(string id)
        {
            var values =await _flightCollection.Find(x => x.FlightId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetFlightByIdDto>(values);
        }

        public async Task UpdateFlightAsync(UpdateFlightDto updateFlightDto)
        {
            var values = _mapper.Map<Flight>(updateFlightDto);
            await _flightCollection.FindOneAndReplaceAsync(x => x.FlightId == updateFlightDto.FlightId, values);
        }
    }
}
