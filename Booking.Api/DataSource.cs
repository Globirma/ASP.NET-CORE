using CwkBooking.domain.Models;



namespace Booking.Api
{
    public class DataSource
    {
        public DataSource()
        {
            Hotels = GetHotels();
        }
        public List<Hotel> Hotels { get; set; }

        //list of hotels to use
        private List<Hotel> GetHotels() => new List<Hotel>
          {

           new Hotel("Luxry", 3 , "UK")
           {
            HotelId = 1,
            Name = "Luxry",
            Star = 3,
            Country = "UK",
            City = "London",
            description = "some nice description"
           },

           new Hotel("westin", 4 , "USA")
           {
            HotelId = 2,
            Name = "Westin",
            Star = 4,
            Country = "USA",
            City = "Seattle",
            description = "some nice description"
           }
            };

    }
    
    }

