using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.Business.Concrete
{
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;
        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }
        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public void DeleteHotel(int id)
        {
            _hotelRepository.DeleteHotel(id);
        }

        public List<Hotel> GetAllHotel()
        {
            return _hotelRepository.GetAllHotels();
        }

        public Hotel GetHotelByCity(string city)
        {
            if (city != null)
            {
                return _hotelRepository.GetHotelByCity(city);
            }
            else
            {
                throw new Exception("Şehir değeri boş olamaz!");
            }
        }

        public Hotel GetHotelByIdAndName(int id)
        {
            if (id>0)
            {
                return _hotelRepository.GetHotelById(id);
            }
            else
            {
                throw new Exception("ID 1 den küçük olamaz!");
            }
            
        }

        public Hotel GetHotelByName(string name)
        {
            if (name!=null)
            {
                return _hotelRepository.GetHotelByName(name);
            }
            else
            {
                throw new Exception("Otel adı boş olamaz!");
            }
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelRepository.UpdateHotel(hotel);
        }
    }
}
