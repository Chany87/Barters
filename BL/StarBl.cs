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
using Microsoft.EntityFrameworkCore.Query;

namespace BL
{
    public class StarBl : IStarBl
    {
        IStarDAL _StarDAL;
        IMapper _mapper;
        public StarBl(IStarDAL starDAL)
        {
            _StarDAL = starDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });

            _mapper = config.CreateMapper();
        }
        public List<StarDTO> GetAllStars()
        {
            List<Star> ListStars = _StarDAL.GetAllStars();
            return _mapper.Map<List<StarDTO>>(ListStars);
        }
        public StarDTO GetStarById(int id)
        {
            try
            {
                var star = _StarDAL.GetStarById(id);
                return _mapper.Map<StarDTO>(star);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddStar(StarDTO star)
        {
            return _StarDAL.AddStar(_mapper.Map<StarDTO, Star>(star));
        }

        public bool DeleteStar(int id)
        {
            return _StarDAL.DeleteStar(id);
        }

        public bool updateStar(int id, StarDTO star)
        {
            Star star1 = _mapper.Map<StarDTO, Star>(star);
            return _StarDAL.UpdateStar(id, star1);
        }
    }
}




