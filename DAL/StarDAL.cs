using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StarDAL : IStarDAL
    {
        BartersDBContext BartersDBContext = new BartersDBContext();

        public List<Star> GetAllStars()
        {
            try
            {
                var stars = BartersDBContext.Stars.ToList();
                return stars;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Star GetStarById(int id)
        {
            try
            {
                var star = BartersDBContext.Stars.SingleOrDefault(s => s.Id == id);
                return star;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddStar(Star star)
        {
            try
            {
                BartersDBContext.Stars.Add(star);
                BartersDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteStar(int id)
        {
            try
            {
                Star star = BartersDBContext.Stars.SingleOrDefault(x => x.Id == id);
                BartersDBContext.Stars.Remove(star);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateStar(int id, Star star)
        {
            try
            {
                Star star1 = BartersDBContext.Stars.SingleOrDefault(x => x.Id == id);
                BartersDBContext.Entry(star1).CurrentValues.SetValues(star);
                BartersDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
