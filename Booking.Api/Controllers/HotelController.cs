using CwkBooking.domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Api.Controllers
{
    //CRUD
    //create
    //read - get all ,get by id
    //update
    //delete
    // usually all crontrollers has this behaviour
    [ApiController]
    [Route("api/[Controller]")]
    public class HotelController : Controller
     { 
        private readonly DataSource _dataSource;
        public HotelController(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        // this is a method and are usually call actions
        // Get all
        [HttpGet]
        public IActionResult GetAllHotels()
        {
            var hotels = _dataSource.Hotels;
            return Ok(hotels);
        }

        // Get by id
        [Route("{id}")]
        [HttpGet]
        public IActionResult GetHotelById(int id)
        {
            var hotels =_dataSource.Hotels;
            var hotel = hotels.FirstOrDefault(h => h.HotelId == id);

            if (hotel == null)
                return NotFound();

            return Ok(hotel);
        }
        [HttpPost]
        public IActionResult CreateHotel([FromBody] Hotel hotel)
        {
            var hotels =_dataSource.Hotels;
            hotels.Add(hotel);
            return CreatedAtAction(nameof(GetHotelById), new { id = hotel.HotelId }, hotel);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateHotel([FromBody] Hotel updated, int id)
        {
            var hotels = _dataSource.Hotels;
            var old = hotels.FirstOrDefault(h => h.HotelId == id);
            if (old == null)    
                return NotFound("no resource with the corresponding ID found");
            hotels.Remove(old);
            hotels.Add(updated);
            return NoContent();
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteHotel(int id)
        {
            var hotels = _dataSource.Hotels;
            var toDelete = hotels.FirstOrDefault(h => h.HotelId == id);
            if (toDelete == null)
                return NotFound("no resource with the corresponding ID found");
            hotels.Remove(toDelete);
            return NoContent();
        }
        
        
    }
}


