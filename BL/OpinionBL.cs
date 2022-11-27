using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL;
using DAL;
using DAL.Models;
using DTO;

namespace BL
{
    public class OpinionBL : IOpinionBL
    {
        IOpinionDAL _opinionDAL;
        IMapper _mapper;
        public OpinionBL(IOpinionDAL opinionDAL)
        {
            _opinionDAL = opinionDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            _mapper = config.CreateMapper();
        }
        public List<OpinionDTO> GetOpinions()
        {
            List<Opinion> opinions = _opinionDAL.GetOpinions();
            return _mapper.Map<List<OpinionDTO>>(opinions);
        }

        public OpinionDTO GetOpinionById(int id)
        {
            try
            {
                var opinion = _opinionDAL.GetOpinionById(id);
                return Mapper.Map<OpinionDTO>(opinion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddOpinion(OpinionDTO opinion)
        {
            return _opinionDAL.AddOpinion(_mapper.Map<OpinionDTO, Opinion>(opinion));
        }

        public bool DeleteOpinion(int id)
        {
            return _opinionDAL.DeleteOpinion(id);
        }
        public bool UpdateOpinion(int id, OpinionDTO opinion)
        {
            Opinion opinion1 = _mapper.Map<OpinionDTO, Opinion>(opinion);
            return _opinionDAL.UpdateOpinion(id, opinion1);
        }
    }

}
