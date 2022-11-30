using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerInquiryDAL : ICustomerInquiryDAL
    {
        BartersDBContext BartersDBContext = new BartersDBContext();
        public List<CustomerInquiry> GetCustomerInquiries()
        {
            try
            {
                var Inquiries = BartersDBContext.CustomerInquiries.ToList();
                return Inquiries;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CustomerInquiry GetCustomerInquiryById(int id)
        {
            try
            {
                var Inquiries = BartersDBContext.CustomerInquiries.SingleOrDefault(x => x.Id == id);
                return Inquiries;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddInquiries(CustomerInquiry customerInquiry)
        {
            try
            {
                BartersDBContext.CustomerInquiries.Add(customerInquiry);
                BartersDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteInquiries(int id)
        {
            try
            {
                CustomerInquiry inquiry = BartersDBContext.CustomerInquiries.SingleOrDefault(x => x.Id == id);
                BartersDBContext.Remove(inquiry);
                BartersDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateInquiries(int id, CustomerInquiry customerInquiry)
        {
            try
            {
                CustomerInquiry inquiry = BartersDBContext.CustomerInquiries.SingleOrDefault(x => x.Id == id);
                BartersDBContext.Entry(inquiry).CurrentValues.SetValues(customerInquiry);
                BartersDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}


