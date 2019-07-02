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

         public string ReperationType { get; set; }
         public string ReperationTypeDescription { get; set; }
         

    
    }
}