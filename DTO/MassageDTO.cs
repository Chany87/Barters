using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MassageDTO
    {
        public int Id { get; set; }
        public int? UsreIdReceived { get; set; }
        public int? UserIdGiven { get; set; }
        public DateTime? MassageDate { get; set; }
        public string MassageContent { get; set; }

    }
}
