using DAL.Models;
using System.Collections.Generic;

namespace DAL
{
    public interface ICityDAL
    {
        List<City> GetCities();
        City GetCityById(int id);
    }
}