using DAL.Models;
using System.Collections.Generic;

namespace DAL
{
    public interface IOpinionDAL
    {
        bool AddOpinion(Opinion opinion);
        bool DeleteOpinion(int id);
        Opinion GetOpinionById(int id);
        List<Opinion> GetOpinions();
        bool UpdateOpinion(int id, Opinion opinion);
    }
}