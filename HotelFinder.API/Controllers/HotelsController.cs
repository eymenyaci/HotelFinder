using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using HotelFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelService;
        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }
        /// <summary>
        /// Get All Hotels
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var hotels = _hotelService.GetAllHotel();
            return Ok(hotels); //200 + data
        }
        /// <summary>
        /// Get Hotel By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetByIdAndName(int id,string name)
        {
            var hotel = _hotelService.GetHotelById(id);
            if (hotel !=null)
            {
                return Ok(hotel); // 200 + data
            }
            return NotFound();
        }
        
        /// <summary>
        /// Get Hotel By Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]/{name}")]
        public IActionResult GetByName(string name)
        {
            var hotel = _hotelService.GetHotelByName(name);
            if (hotel != null)
            {
                return Ok(hotel); // 200 + data
            }
            return NotFound();
        }
        
        /// <summary>
        /// Get Hotel By City
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]/{city}")]
        public IActionResult GetByCity(string city)
        {
            var hotel = _hotelService.GetHotelByCity(city);
            if (hotel != null)
            {
                return Ok(hotel); // 200 + data
            }
            return NotFound();
        }


        /// <summary>
        /// Create an Hotel
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody]Hotel hotel)
        {
            var createdHotel = _hotelService.CreateHotel(hotel);
            return CreatedAtAction("Get", new { id = createdHotel.Id }, createdHotel);
        }
        /// <summary>
        /// Update the Hotel
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put([FromBody] Hotel hotel)
        {
            if (_hotelService.GetHotelById(hotel.Id)!=null)
            {
                return Ok(_hotelService.UpdateHotel(hotel)); // 200 + data
            }

            return NotFound();
        }
        /// <summary>
        /// Delete The Hotel
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_hotelService.GetHotelById(id) != null)
            {
                _hotelService.DeleteHotel(id);
                return Ok(); // 200
            }

            return NotFound();
        }
    }
}
