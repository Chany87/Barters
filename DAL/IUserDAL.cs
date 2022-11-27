using DAL.Models;
using System.Collections.Generic;

namespace DAL
{
    public interface IUserDAL
    {
        bool AddUser(User user);
        bool DeleteUser(int id);
        List<User> GetAllUsers();
        User GetUserById(int id);
        bool UpdateUsers(int id, User user);
    }
}