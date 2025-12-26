using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class BookingMaster
    {
        public int BookingNo { get; set; }
        public string Username { get; set; }
        public DateTime BookingDate { get; set; }
        public string ApprovalStatus { get; set; }
    }
}