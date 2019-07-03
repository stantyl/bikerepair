using System;

namespace DatingApp.API.Helpers
{
    public class ReservationParam
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize;}
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value;}
        }

        public int UserId { get; set; }
        public string Gender { get; set; }


     public int Id { get; set; }
        public string Adress { get; set; }
        public DateTime DateBooked { get; set; }
     public DateTime TypeOfreperation { get; set; }


        public DateTime ReparationDateTimeStart { get; set; }
            public DateTime ReparationDateTimeEnd { get; set; }






        public string OrderBy { get; set; }
    }
}