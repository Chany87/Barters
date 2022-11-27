using API.Controllers;
using BL;
using DAL.Models;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpinionController : ControllerBase
    {
        private IOpinionBL _opinionBL;

        public OpinionController(IOpinionBL opinionBL)
        {
            _opinionBL = opinionBL;
        }
        [HttpGet]
        [Route("GetAllOpinion")]
        public ActionResult<List<Opinion>> GetAllOpinion()
        {
            try
            {
                return Ok(_opinionBL.GetOpinions());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetOpinionById/{id}")]
        public ActionResult<OpinionDTO> GetOpinionById(int id)
        {
            OpinionDTO opinion = _opinionBL.GetOpinionById(id);
            if (opinion == null)
                return NotFound();
            return Ok(opinion);
        }
        [HttpPost]
        [Route("AddOpinion")]
        public bool AddOpinion([FromBody] OpinionDTO opinion)
        {
            var x = _opinionBL.AddOpinion(opinion);
            return x;
        }

        [HttpDelete]
        [Route("DeleteOpinion")]
        public bool DeleteOpinion(int id)
        {
            return _opinionBL.DeleteOpinion(id);
        }

        [HttpPut]
        [Route("Update{id}")]
        public bool UodateOpinion(int id, [FromBody] OpinionDTO opinion)
        {
            return _opinionBL.UpdateOpinion(id, opinion);   
        }
    }
   }
