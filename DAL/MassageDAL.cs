using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MassageDAL : IMassageDAL
    {

        BartersDBContext bartersDBContext = new BartersDBContext();
        public List<Massage> GetAllMassages()
        {
            //select * from Users; 
            try
            {
                List<Massage> massages = bartersDBContext.Massages.ToList();
                return massages;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Massage GetMassageById(int id)
        {
            //select * from Users; 
            try
            {
                Massage massage = bartersDBContext.Massages.SingleOrDefault(x => x.Id == id);
                return massage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Addmassage(Massage massage)
        {
            //פונקצית הוספה
            try
            {

                bartersDBContext.Massages.Add(massage);
                bartersDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
   
