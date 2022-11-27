using API.Controllers;
using BL;
using DAL.Models;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserBL _userBL;
        public UsersController(IUserBL userBL)
        {
            _userBL = userBL;
        }
        [HttpGet]
        [Route("GetAllUsers")]
        public ActionResult<List<UserDTO>> GetAllUsers()
        {
            List<UserDTO> users = _userBL.GetAllUsers();
            if (users == null)
                return NotFound();
            return Ok(users);
        }

        [HttpGet]
        [Route("GetUserById/{id}")]
        public ActionResult<UserDTO> GetUserById(int id)
        {
           UserDTO user = _userBL.GetUserById(id);
            if(user == null)
                return NotFound();
            return Ok(user);
        }
        [HttpPost]
        [Route("AddUSer")]
        public bool AddUser([FromBody] UserDTO user)
        {
            var x = _userBL.AddUser(user);
            return x;
        }
        [HttpDelete]
        [Route("DeleteUser")]
        public bool DeleteUser(int id)
        {
            return _userBL.DeleteUser(id);
        }

        [HttpPut]
        [Route("Update/{id}")]
        public ActionResult<bool> UpdateUser(int id, [FromBody] UserDTO user)
        {
            if (user.Id != id)

                return StatusCode(400, "");
            return Ok(_userBL.UpdateUser(id, user));
        }
    }
}


