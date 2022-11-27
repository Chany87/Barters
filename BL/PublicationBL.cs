using AutoMapper;
using BL;
using DAL.Models;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
    public class PublicationBL : IPublicationBL
    {
        IPublicationDAL _publicationDAL;
        IMapper _mapper;
        public PublicationBL(IPublicationDAL publicationDAL)
        {
            _publicationDAL = publicationDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            _mapper = config.CreateMapper();
        }
        public List<PublicationDTO> GetAllPublications()
        {
            List<Publication> listPublications = _publicationDAL.getAllPublications();

            return _mapper.Map<List<PublicationDTO>>(listPublications);
        }
        public PublicationDTO GetPublicationById(int id)
        {
            try
            {
                var publication = _publicationDAL.GetPublicationById(id);
                return _mapper.Map<PublicationDTO>(publication);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddPublication(PublicationDTO publication)
        {
            return _publicationDAL.AddPublication(_mapper.Map<PublicationDTO, Publication>(publication));
        }

        public bool DeletePublication(int id)
        {
            return _publicationDAL.DeletePublication(id);
        }

        public bool UpdatePublication(int id, PublicationDTO publication)
        {
            Publication publication1 = _mapper.Map<PublicationDTO, Publication>(publication);
            return _publicationDAL.updatePublication(id, publication1);
        }
    }
}
