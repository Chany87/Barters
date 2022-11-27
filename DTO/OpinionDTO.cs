using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OpinionDTO
    {
        public int Id { get; set; }
        public DateTime? DateAdded { get; set; }
        public int? Rating { get; set; }
        public int? DrageId { get; set; }
        public int? GradedId { get; set; }
        public string OpinionContent { get; set; }
    }
}
