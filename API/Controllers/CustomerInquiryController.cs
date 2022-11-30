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
    public class CustomerInquiryController : ControllerBase
    {
        private ICustomerInquiryBL _customerInquiryBL;
        public CustomerInquiryController(ICustomerInquiryBL customerInquiryBL)
        {
            _customerInquiryBL = customerInquiryBL;
        }

        [HttpGet]
        [Route("getCustomerInquiry")]
        public ActionResult<List<CustomerInquiry>> GetInquiries()
        {
            try
            {
                return Ok(_customerInquiryBL.GetAllInquiries());
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetInquiriById/{id}")]
        public ActionResult<CustomerInquiryDTO> GetInquiriById(int id)
        {
            CustomerInquiryDTO customer = _customerInquiryBL.GetCustomerInquiry(id);
            if (customer == null)
                return NotFound();
            return Ok(customer);
        }
        [HttpPost]
        [Route("Addinquiri")]
        public bool Addinquiri([FromBody] CustomerInquiryDTO customerInquiry)
        {
            var x = _customerInquiryBL.AddInquiries(customerInquiry);
            return x;
        }

        [HttpDelete]
        [Route("Delete")]
        public bool DeleteInquiries(int id)
        {
            return _customerInquiryBL.DeleteInquiries(id);
        }
        [HttpPut]
        [Route("Update")]
        public bool UpdateInquiries(int id, [FromBody] CustomerInquiryDTO customerInquiry)
        {
            return _customerInquiryBL.UpdateInquiries(id, customerInquiry);
        }
    }
}





