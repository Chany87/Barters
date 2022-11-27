using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Star
    {
        public int Id { get; set; }
        public int? UserIdGiven { get; set; }
        public int? UserIdReceived { get; set; }
        public DateTime? DateGiven { get; set; }
        public DateTime? DateReceived { get; set; }

        public virtual User UserIdGivenNavigation { get; set; }
        public virtual User UserIdReceivedNavigation { get; set; }
    }
}
