using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL;
using DAL;
using DAL.Models;
using DTO;

namespace BL
{
    public class CityBL : ICityBL
    {
        ICityDAL _cityDAL;
        IMapper _mapper;
        public CityBL(ICityDAL cityDAL)
        {
            _cityDAL = cityDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            _mapper = config.CreateMapper();
        }

        public List<CityDTO> GetCities()
        {
            List<City> cities = _cityDAL.GetCities();
            return _mapper.Map<List<CityDTO>>(cities);
        }

        public CityDTO GetCityById(int id)
        {
            try
            {
                var city = _cityDAL.GetCityById(id);
                return _mapper.Map<CityDTO>(city);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

