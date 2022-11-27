using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Opinion
    {
        public int Id { get; set; }
        public DateTime? DateAdded { get; set; }
        public int? Rating { get; set; }
        public int? DrageId { get; set; }
        public int? GradedId { get; set; }
        public string OpinionContent { get; set; }

        public virtual User Drage { get; set; }
        public virtual User Graded { get; set; }
    }
}
