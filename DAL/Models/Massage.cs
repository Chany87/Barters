using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Massage
    {
        public int Id { get; set; }
        public int? UsreIdReceived { get; set; }
        public int? UserIdGiven { get; set; }
        public DateTime? MassageDate { get; set; }
        public string MassageContent { get; set; }

        public virtual User UserIdGivenNavigation { get; set; }
        public virtual User UsreIdReceivedNavigation { get; set; }
    }
}
