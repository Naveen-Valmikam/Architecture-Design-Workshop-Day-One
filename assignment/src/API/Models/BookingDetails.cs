namespace API.Models
{
    public class BookingDetails
    {
        public int NumberOfAdults { get; set; }
        public int CityId { get; set; }
        public string CheckinDate { get; set; }
        public string CheckoutDate { get; set; }
        public string GuestId { get; set; }
    }
}