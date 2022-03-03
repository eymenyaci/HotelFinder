using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Concrete
{
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;
        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }
        public async Task<Hotel> CreateHotel(Hotel hotel)
        {
            return await _hotelRepository.CreateHotel(hotel);
        }

        public async Task DeleteHotel(int id)
        {
            await _hotelRepository.DeleteHotel(id);
        }

        public async Task<List<Hotel>> GetAllHotel()
        {
            return await _hotelRepository.GetAllHotels();
        }

        public async Task<Hotel> GetHotelByCity(string city)
        {
            if (city != null)
            {
                return await _hotelRepository.GetHotelByCity(city);
            }
            else
            {
                throw new Exception("Şehir değeri boş olamaz!");
            }
        }

        public Task<Hotel> GetHotelById(int id)
        {
            if (id > 0)
            {
                return _hotelRepository.GetHotelById(id);
            }
            else
            {
                throw new Exception("ID 1 den küçük olamaz!");
            }
        }

        public async Task<Hotel> GetHotelByName(string name)
        {
            if (name!=null)
            {
                return  await _hotelRepository.GetHotelByName(name);
            }
            else
            {
                throw new Exception("Otel adı boş olamaz!");
            }
        }

        public async Task<Hotel> UpdateHotel(Hotel hotel)
        {
            return await _hotelRepository.UpdateHotel(hotel);
        }
    }
}
