using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Reservation
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string AdditionalInfo { get; set; }
        public DateTime Date { get; set; }

        public int ReservationNumber { get; set; }
    }
}
