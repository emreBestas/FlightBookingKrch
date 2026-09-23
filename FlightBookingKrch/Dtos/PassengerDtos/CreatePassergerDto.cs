namespace FlightBookingKrch.Dtos.PassengerDtos
{
    public class CreatePassergerDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string PassengerType { get; set; }
    }
}
