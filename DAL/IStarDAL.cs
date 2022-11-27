using DAL.Models;
using System.Collections.Generic;

namespace DAL
{
    public interface IStarDAL
    {
        bool AddStar(Star star);
        bool DeleteStar(int id);
        List<Star> GetAllStars();
        Star GetStarById(int id);
        bool UpdateStar(int id, Star star);
    }
}