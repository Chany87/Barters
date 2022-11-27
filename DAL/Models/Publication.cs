using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Publication
    {
        public int Id { get; set; }
        public int? UserIdPublish { get; set; }
        public DateTime? PublicationDate { get; set; }
        public DateTime? ClosingDate { get; set; }
        public string PublicationContent { get; set; }
        public bool? IfStar { get; set; }
        public int? CategoryIdNeed { get; set; }
        public int? UserIdReceived { get; set; }

        public virtual User UserIdPublishNavigation { get; set; }
        public virtual User UserIdReceivedNavigation { get; set; }
    }
}
