using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwkBooking.domain.Models
{
    public class Hotel
    {
        public Hotel(string Name, int Star , string Country) { 

        }

        public int HotelId { get; set; }
        public string Name { get; set; }
        public int Star { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string description { get; set; }   
        public List<Room> Rooms { get; set; }


    }
}
