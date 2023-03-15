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
        private List<Hotel> GetHotels()
        {
            return new List<Hotel>
          {
           new Hotel
           {
            HotelId = 1,
            Name = "Luxry",
            Stars = 3,
            Country = "UK",
            City = "London",
            Description = "some nice description"
           },
           new Hotel
           {
            HotelId = 2,
            Name = "Westin",
            Stars = 4,
            Country = "USA",
            City = "Seattle",
            Description = "some nice description"
           }
            }

       }

       }
    
    }

