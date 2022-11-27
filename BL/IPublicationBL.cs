using DTO;
using System.Collections.Generic;

namespace BL
{
    public interface IPublicationBL
    {
        bool AddPublication(PublicationDTO publication);
        bool DeletePublication(int id);
        List<PublicationDTO> GetAllPublications();
        PublicationDTO GetPublicationById(int id);
        bool UpdatePublication(int id, PublicationDTO publication);
    }
}