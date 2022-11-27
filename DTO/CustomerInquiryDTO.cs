using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerInquiryDTO
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? TurnDate { get; set; }
        public string TurnContent { get; set; }

    }
}
