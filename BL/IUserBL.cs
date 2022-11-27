using DTO;
using System.Collections.Generic;

namespace BL
{
    public interface IUserBL
    {
        bool AddUser(UserDTO user);
        bool DeleteUser(int id);
        List<UserDTO> GetAllUsers();
        UserDTO GetUserById(int id);
        bool UpdateUser(int id, UserDTO user);
    }
}