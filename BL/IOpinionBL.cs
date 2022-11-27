using DTO;
using System.Collections.Generic;

namespace BL
{
    public interface IOpinionBL
    {
        bool AddOpinion(OpinionDTO opinion);
        bool DeleteOpinion(int id);
        OpinionDTO GetOpinionById(int id);
        List<OpinionDTO> GetOpinions();
        bool UpdateOpinion(int id, OpinionDTO opinion);
    }
}