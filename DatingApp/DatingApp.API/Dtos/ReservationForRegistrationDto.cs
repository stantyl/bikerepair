using System;

namespace DatingApp.API.Dtos
{
    public class ReservationForCreationDto
    {
        public string Adress { get; set; }
  
        public DateTime DateBooked { get; set; }
     public string TypeOfreperation { get; set; }
     public string TypeOfreperationDescription { get; set; }

        public DateTime ReparationDateTimeStart { get; set; }
            public DateTime ReparationDateTimeEnd { get; set; }
            public decimal Price { get; set; }
            public string Currency { get; set; }


         
    }
    }
