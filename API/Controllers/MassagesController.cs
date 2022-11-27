using BL;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MassagesController : ControllerBase
    {
        IMassageBL _massageBL;
        public MassagesController(IMassageBL massageBL)
        {
            _massageBL = massageBL;
        }
        [HttpGet]
        [Route("GetAllMassages")]
        public ActionResult<List<MassageDTO>> GetAllMassages()
        {
            List<MassageDTO> massages = _massageBL.GetAllMassages();
            if (massages == null)
                return NotFound();
            return Ok(massages);
        }
        [HttpGet]
        [Route("GetMassageById/{id}")]
        public ActionResult<MassageDTO> GetMassageById(int id)
        {
            MassageDTO massage = _massageBL.GetMassageById(id);
            if (massage == null)
                return NotFound();
            return Ok(massage);
        }
        [HttpPost]
        [Route("Add")]
        public ActionResult<bool> AddMassage([FromBody] MassageDTO massageDTO)
        {

            return Ok(_massageBL.AddMassage(massageDTO));

        }

    }
}
