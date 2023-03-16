using CwkBooking.domain.Models;

namespace Booking.Api.services
{
    public class MyFirstService
    {
        //dependency injection
        private readonly DataSource _dataSource;

        public MyFirstService(DataSource dataSource)
        {
            _dataSource = dataSource;

        }

        public List<Hotel> GetHotels()
        {
            return _dataSource.GetHotels;
        }
    }
}
