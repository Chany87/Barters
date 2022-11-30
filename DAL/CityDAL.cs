using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CityDAL : ICityDAL
    {
        BartersDBContext BartersDBContext = new BartersDBContext();

        public List<City> GetCities()
        {
            try
            {
                var city = BartersDBContext.Cities.ToList();
                return city;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public City GetCityById(int id)
        {
            try
            {
                var city = BartersDBContext.Cities.SingleOrDefault(x => x.Id == id);
                return city;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

