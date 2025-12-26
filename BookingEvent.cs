using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class BookingEvent
    {
        public string EventType { get; set; }
        public string VenueType { get; set; }
        public int NoOfGuest { get; set; }
    }
}