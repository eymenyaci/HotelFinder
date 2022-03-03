using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.Business.Abstract
{
    public interface IHotelService
    {
        List<Hotel> GetAllHotel();
        Hotel GetHotelById(int id);
        Hotel GetHotelByName(string name);
        Hotel GetHotelByCity(string city);
        Hotel CreateHotel(Hotel hotel);
        Hotel UpdateHotel(Hotel hotel);
        void DeleteHotel(int id);
    }
}
