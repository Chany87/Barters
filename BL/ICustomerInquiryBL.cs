using DTO;
using System.Collections.Generic;

namespace BL
{
    public interface ICustomerInquiryBL
    {
        bool AddInquiries(CustomerInquiryDTO inquiries);
        bool DeleteInquiries(int id);
        List<CustomerInquiryDTO> GetAllInquiries();
        CustomerInquiryDTO GetCustomerInquiry(int id);
        bool UpdateInquiries(int id, CustomerInquiryDTO inquiries);
    }
}