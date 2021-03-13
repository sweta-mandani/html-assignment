using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Models.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public System.DateTime BookingDate { get; set; }
        public Nullable<int> Room_id { get; set; }
        public string StatusOfBooking { get; set; }

        
    }
}
