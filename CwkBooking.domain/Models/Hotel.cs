using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwkBooking.domain.Models
{
    public class Hotel
    {
        public Hotel (string name, int star, string address) {

         if  (string.IsNullOrWhiteSpace(name))
            
                throw new ArgumentNullException("HOtel name can't be null or whitespace."); 
            
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
