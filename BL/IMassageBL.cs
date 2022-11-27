using DTO;
using System.Collections.Generic;

namespace BL
{
    public interface IMassageBL
    {
        List<MassageDTO> GetAllMassages();
        MassageDTO GetMassageById(int id);
        bool AddMassage(MassageDTO massageDTO);
    }
}