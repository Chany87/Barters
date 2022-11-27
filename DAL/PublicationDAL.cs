using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PublicationDAL : IPublicationDAL
    {
        BartersDBContext BartersDBContext = new BartersDBContext();
        public List<Publication> getAllPublications()
        {
            try
            {
                var publication = BartersDBContext.Publications.ToList();
                return publication;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Publication GetPublicationById(int id)
        {
            try
            {
                var publication = BartersDBContext.Publications.SingleOrDefault(x => x.Id == id);
                return publication;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddPublication(Publication publication)
        {
            try
            {
                BartersDBContext.Publications.Add(publication);
                BartersDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeletePublication(int id)
        {
            try
            {
                Publication publication = BartersDBContext.Publications.SingleOrDefault(x => x.Id == id);
                BartersDBContext.Publications.Remove(publication);
                BartersDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool updatePublication(int id, Publication publication)
        {
            try
            {
                Publication publication1 = BartersDBContext.Publications.SingleOrDefault(x => x.Id == id);
                BartersDBContext.Entry(publication1).CurrentValues.SetValues(publication);
                BartersDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
