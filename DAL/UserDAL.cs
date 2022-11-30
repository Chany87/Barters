using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        //public User Logim(string email, int password)
        //{
        //    User user = bartersDBContext.Users.SingleOrDefault(x >= x.Email.Equals(ema
        //}

        //public User Login(string email, string password)
        //{
        //    User user = _Context.Users.SingleOrDefault(x => x.Email.Equals(email) && x.Password.Equals(password));
        //    return user;
        //}

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




