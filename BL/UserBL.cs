using AutoMapper;
using DAL;
using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UserBL : IUserBL
    {
        IUserDAL _userDal;

        IMapper mapper;
        public UserBL(IUserDAL userDAL)
        {
            _userDal = userDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        public List<UserDTO> GetAllUsers()
        {
            List<User> listUsers = _userDal.GetAllUsers();

            return mapper.Map<List<UserDTO>>(listUsers);
        }
        public UserDTO GetUserById(int id)
        {

            try
            {
                var User = _userDal.GetUserById(id);
                return mapper.Map<UserDTO>(User);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddUser(UserDTO user)
        {
            return _userDal.AddUser(mapper.Map<UserDTO, User>(user));

        }
        public bool DeleteUser(int id)
        {
            return _userDal.DeleteUser(id);

        }

        public bool UpdateUser(int id, UserDTO user)
        {
            User user1 = mapper.Map<UserDTO, User>(user);
            return _userDal.UpdateUsers(id, user1);
        }
    }
}



