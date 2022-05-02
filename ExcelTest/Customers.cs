using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTest
{
    public class Customers
    {
        public string Property { get; set; } 
        public string Guest { get; set; }
        public string Source { get; set; }
        public string Reservation { get; set; }
        public string CreatedOn { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }


       public Customers(
           string property,
           string guest,
           string source,
           string reservation,
           string createdOn,
           string checkIn,
           string checkOut) 
        {
            Property = property;
            Guest = guest;
            Source = source;
            Reservation = reservation;
            CreatedOn = createdOn;
            CheckIn = checkIn;  
            CheckOut = checkOut;

        
        }
    }
}
