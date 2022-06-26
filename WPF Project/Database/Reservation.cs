using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Project.Database
{
    public class Reservation
    {
        public int ReservationID { get; set; }

        public DateTime ReservedTime { get; set; }

        public virtual Doctor Doctor { get; set; }

        public Reservation(DateTime reservedTime)
        {
            ReservedTime = reservedTime;
        }

        public Reservation()
        {
        }
    }
}
