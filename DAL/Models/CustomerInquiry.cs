using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CustomerInquiry
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? TurnDate { get; set; }
        public string TurnContent { get; set; }

        public virtual User User { get; set; }
    }
}
