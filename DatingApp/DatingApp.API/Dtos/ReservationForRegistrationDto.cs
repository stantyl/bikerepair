using System;

namespace DatingApp.API.Dtos
{
    public class ReservationForCreationDto
    {


// 1 basic
public string Adress { get; set; }
public DateTime ReparationDate { get; set; }
public string ReparationTime { get; set; }


// reparation details 
public string TypeOfreperation { get; set; }
public string TypeOfBike { get; set; }
public string TypeOfreperationDescription { get; set; }



// customer data
public string FirstName { get; set; }
public string Lastname { get; set; }
public string Email { get; set; }



  }
  }
    
