using DAL.Models;
using System.Collections.Generic;

namespace DAL
{
    public interface IMassageDAL
    {
        List<Massage> GetAllMassages();
        Massage GetMassageById(int id);
        bool Addmassage(Massage massage);
    }
}