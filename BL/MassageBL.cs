using AutoMapper;
using DAL;
using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class MassageBL : IMassageBL
    {
        IMassageDAL _massageDal;

        IMapper mapper;
        public MassageBL(IMassageDAL massageDAL)
        {
            _massageDal = massageDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }
        public List<MassageDTO> GetAllMassages()
        {
            List<Massage> listMassages = _massageDal.GetAllMassages();

            return mapper.Map<List<MassageDTO>>(listMassages);
        }
        public MassageDTO GetMassageById(int id)
        {

            try
            {
                var Massage = _massageDal.GetMassageById(id);
                return mapper.Map<MassageDTO>(Massage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddMassage(MassageDTO massageDTO)
        {
            //פונקצית הוספה
            try
            {
                Massage massage = mapper.Map<Massage>(massageDTO);
                return _massageDal.Addmassage(massage);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



    }
}
