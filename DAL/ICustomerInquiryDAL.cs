using DAL.Models;
using System.Collections.Generic;

namespace DAL
{
    public interface ICustomerInquiryDAL
    {
        bool AddInquiries(CustomerInquiry customerInquiry);
        bool DeleteInquiries(int id);
        List<CustomerInquiry> GetCustomerInquiries();
        CustomerInquiry GetCustomerInquiryById(int id);
        bool UpdateInquiries(int id, CustomerInquiry customerInquiry);
    }
}