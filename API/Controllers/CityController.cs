using DAL.Models;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using BL;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private ICityBL _cityBL;
        public CityController(ICityBL cityBL)
        {
            _cityBL = cityBL;
        }
        [HttpGet]
        public ActionResult<List<City>> GetAllCities() 
        {
            try
            {
                return Ok(_cityBL.GetCities());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetCityById{id}")]
        public ActionResult<CityDTO> GetCity(int id)
        {
            CityDTO city = _cityBL.GetCityById(id);
            if (city == null)
                return NotFound();
            return Ok(city);
        }
    }
}
