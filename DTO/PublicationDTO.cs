using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PublicationDTO
    {
        public int Id { get; set; }
        public int? UserIdPublish { get; set; }
        public DateTime? PublicationDate { get; set; }
        public DateTime? ClosingDate { get; set; }
        public string PublicationContent { get; set; }
        public bool? IfStar { get; set; }
        public int? CategoryIdNeed { get; set; }
        public int? UserIdReceived { get; set; }
    }
}
