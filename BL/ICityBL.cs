using DTO;
using System.Collections.Generic;

namespace BL
{
    public interface ICityBL
    {
        List<CityDTO> GetCities();
        CityDTO GetCityById(int id);
    }
}