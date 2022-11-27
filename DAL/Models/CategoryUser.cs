using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CategoryUser
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? CategotyId { get; set; }

        public virtual Category Categoty { get; set; }
        public virtual User User { get; set; }
    }
}
