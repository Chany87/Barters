using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using BL;
using DTO;
using System.Collections.Generic;
using DAL.Models;
using DAL;
using API.Controllers;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicationController : ControllerBase
    {
        private IPublicationBL _publicationBL;

        public PublicationController(IPublicationBL publication)
        {
            _publicationBL = publication;
        }
        [HttpGet]
        [Route("GetAllPublications")]
        public ActionResult<List<Publication>> GetAllPublications()
        {
            try
            {
                return Ok(_publicationBL.GetAllPublications());
            }
            catch (Exception ex) 
            { 
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetPublicationById/{id}")]
        public ActionResult<PublicationDTO> GetPublicationById(int id) 
        { 
            PublicationDTO publication = _publicationBL.GetPublicationById(id);
            if(publication == null)
                return NotFound();
            return Ok(publication);
        }
        [HttpPost]
        [Route("AddPublication")]
        public bool AddPublucation([FromBody] PublicationDTO publication)
        {
            var x = _publicationBL.AddPublication(publication);
            return x;
        }
        [HttpDelete]
        public bool DeletePublication(int id)
        {
            return _publicationBL.DeletePublication(id);
        }

        [HttpPut]
        [Route("Update/{id}")]
        public ActionResult<bool> UpdatePublication(int id, [FromBody] PublicationDTO publication)
        {

            if(publication.Id != id)
            
                return StatusCode(400, "Id not found");

              return Ok(_publicationBL.UpdatePublication(id, publication));
        }
    }
}

