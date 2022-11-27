using DAL.Models;
using System.Collections.Generic;

namespace DAL
{
    public interface IPublicationDAL
    {
        bool AddPublication(Publication publication);
        bool DeletePublication(int id);
        List<Publication> getAllPublications();
        Publication GetPublicationById(int id);
        bool updatePublication(int id, Publication publication);
    }
}