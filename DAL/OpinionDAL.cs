using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OpinionDAL : IOpinionDAL
    {
        BartersDBContext BartersDBContext = new BartersDBContext();

        public List<Opinion> GetOpinions()
        {
            try
            {
                var opinion = BartersDBContext.Opinions.ToList();
                return opinion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Opinion GetOpinionById(int id)
        {
            try
            {
                var opinion = BartersDBContext.Opinions.SingleOrDefault(x => x.Id == id);
                return opinion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddOpinion(Opinion opinion)
        {
            try
            {
                BartersDBContext.Opinions.Add(opinion);
                BartersDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteOpinion(int id)
        {
            try
            {
                Opinion opinion = BartersDBContext.Opinions.SingleOrDefault(x => x.Id == id);
                BartersDBContext.Remove(opinion);
                BartersDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateOpinion(int id, Opinion opinion)
        {
            try
            {
                Opinion opinion1 = BartersDBContext.Opinions.SingleOrDefault(x => x.Id == id);
                BartersDBContext.Entry(opinion1).CurrentValues.SetValues(opinion);
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


