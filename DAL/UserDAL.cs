using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL : IUserDAL
    {

        BartersDBContext bartersDBContext = new BartersDBContext();
        public List<User> GetAllUsers()
        {
            //select * from Users; 
            try
            {
                var Users = bartersDBContext.Users.ToList();
                return Users;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public User GetUserById(int id)
        {
            //select * from Users; 
            try
            {
                var User = bartersDBContext.Users.SingleOrDefault(x => x.Id == id);
                return User;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddUser(User user)
        {
            try
            {
                bartersDBContext.Users.Add(user);
                bartersDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteUser(int id)
        {
            try
            {
                User user = bartersDBContext.Users.SingleOrDefault(x => x.Id == id);
                bartersDBContext.Users.Remove(user);
                bartersDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateUsers(int id, User user)
        {
            try
            {
                User user1 = bartersDBContext.Users.SingleOrDefault(x => x.Id == id);
                bartersDBContext.Entry(user1).CurrentValues.SetValues(user);
                bartersDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}




