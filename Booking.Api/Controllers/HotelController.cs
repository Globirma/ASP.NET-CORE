using Booking.Api.services;
using Booking.Api.services.Abstraction;
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
        //how to inject depedency in controller
        private readonly MyFirstService _firstService;
        private readonly ISingletonOperation _singleton;
        private readonly ITransientOperation _transient;
        private readonly IScopedOperation _scoped;
        private readonly ILogger<HotelController> _logger;

        // here is all the services we need in the constructor
        public HotelController( MyFirstService service,ISingletonOperation singleton,
            ITransientOperation transient,IScopedOperation scoped, 
            ILogger<HotelController> logger)
        {
            
            _firstService = service;
            _singleton = singleton;
            _transient = transient;
            _scoped = scoped;
            _logger = logger;
        }
        // this is a method and are usually call actions
        // Get all
        [HttpGet]
        public IActionResult GetAllHotels()
        {
            _logger.LogInformation($"Guid of singleton: {_singleton.Guid}");
            _logger.LogInformation($"Guid of transient: {_transient.Guid}");
            _logger.LogInformation($"Guid of scoped: {_scoped.Guid}");

            var hotels = _firstService.GetHotels();
            return Ok(hotels);
        }

        // Get by id
        [Route("{id}")]
        [HttpGet]
        public IActionResult GetHotelById(int id)
        {
            var hotels = _firstService.GetHotels();

            var hotel = hotels.FirstOrDefault(h => h.HotelId == id);

            if (hotel == null)
                return NotFound();

            return Ok(hotel);
        }
        [HttpPost]
        public IActionResult CreateHotel([FromBody] Hotel hotel)
        {
            var hotels = _firstService.GetHotels();
            hotels.Add(hotel);
            return CreatedAtAction(nameof(GetHotelById), new { id = hotel.HotelId }, hotel);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateHotel([FromBody] Hotel updated, int id)
        {
            var hotels = _firstService.GetHotels();
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
            var hotels = _firstService.GetHotels();
            var toDelete = hotels.FirstOrDefault(h => h.HotelId == id);
            if (toDelete == null)
                return NotFound("no resource with the corresponding ID found");
            hotels.Remove(toDelete);
            return NoContent();
        }
        
        
    }
}


