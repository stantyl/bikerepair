using System;
using System.Collections;
using System.Collections.Generic;

namespace DatingApp.API.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public DateTime DateBooked { get; set; }
     public DateTime TypeOfreperation { get; set; }
     public DateTime TypeOfreperationDescription { get; set; }

        public DateTime ReparationDateTimeStart { get; set; }
            public DateTime ReparationDateTimeEnd { get; set; }
            public decimal Price { get; set; }
            public string Currency { get; set; }

         public string ReperationType { get; set; }
         public string ReperationTypeDescription { get; set; }
         

    
    }
}