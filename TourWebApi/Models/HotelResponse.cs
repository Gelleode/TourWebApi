using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TourWebApi.Entities;

namespace TourWebApi.Models
{
    public class HotelResponse
    {

        public HotelResponse(Hotel hotel)
        {
            Id = hotel.Id;
            Name = hotel.Name;
            CountOfStars = hotel.CountOfStars;
            CountryName = hotel.Country.Name;
            HotelImage = hotel.HotelImage.ToList().FirstOrDefault()?.ImageSource;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CountOfStars { get; set; }
        public string CountryName { get; set; }
        public byte[] HotelImage { get; set; }
    }
}