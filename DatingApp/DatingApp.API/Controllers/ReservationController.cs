using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
using DatingApp.API.Helpers;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
   [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IDatingRepository _repo;
        private readonly IMapper _mapper;

        public ReservationController(IDatingRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

     
//http://localhost:5000/api/reservation/book
        [HttpPost("book")]
         [AllowAnonymous]
        public async Task<IActionResult> Reservation(ReservationForCreationDto ReservationForCreationDto)
        {
         
try
{

   var ReservationToCreate = _mapper.Map<Reservation>(ReservationForCreationDto);
//
         _repo.Add<Reservation>(ReservationToCreate);

          await _repo.SaveAll();
           
                return Ok();
}
         catch(Exception e)
         {
              
            return BadRequest("Failed to add reservation tr " + e.Message.ToString()  );
         }



        }

        
    [AllowAnonymous]
    [HttpGet("res")]
 // http://localhost:5000/api/reservation/book



        public IActionResult GetReservations()
        {
          //  ReservationForCreationDto.Adress = userForRegisterDto.Username.ToLower();

           // var createdReservation = await _repo.Register(userToCreate, userForRegisterDto.Password);


                return Ok();
            


        }







    }
}