using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL;
using DAL;
using DAL.Models;
using DTO;

namespace BL
{
    public class CustomerInquiryBL : ICustomerInquiryBL
    {
        ICustomerInquiryDAL _CustomerInquiryDAL;
        IMapper _Mapper;

        public CustomerInquiryBL(ICustomerInquiryDAL customerInquiry)
        {
            _CustomerInquiryDAL = customerInquiry;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            _Mapper = config.CreateMapper();
        }

        public List<CustomerInquiryDTO> GetAllInquiries()
        {
            List<CustomerInquiry> inquiries = _CustomerInquiryDAL.GetCustomerInquiries();
            return _Mapper.Map<List<CustomerInquiryDTO>>(inquiries);
        }
        public CustomerInquiryDTO GetCustomerInquiry(int id)
        {
            try
            {
                var Inquiries = _CustomerInquiryDAL.GetCustomerInquiryById(id);
                return _Mapper.Map<CustomerInquiryDTO>(Inquiries);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddInquiries(CustomerInquiryDTO inquiries)
        {
            return _CustomerInquiryDAL.AddInquiries(_Mapper.Map<CustomerInquiry>(inquiries));
        }

        public bool DeleteInquiries(int id)
        {
            return _CustomerInquiryDAL.DeleteInquiries(id);
        }

        public bool UpdateInquiries(int id, CustomerInquiryDTO inquiries)
        {
            CustomerInquiry inquiry = _Mapper.Map<CustomerInquiryDTO, CustomerInquiry>(inquiries);
            return _CustomerInquiryDAL.UpdateInquiries(id, inquiry);
        }
    }
}

