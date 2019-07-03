using System;
using System.Collections;
using System.Collections.Generic;

namespace DatingApp.API.Models
{
    public class Reservation
{
public int Id { get; set; }

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
public DateTime DateBookedSystem { get; set; }


    }
}
