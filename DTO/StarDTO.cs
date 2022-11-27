using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StarDTO
    {
        public int Id { get; set; }
        public int? UserIdGiven { get; set; }
        public int? UserIdReceived { get; set; }
        public DateTime? DateGiven { get; set; }
        public DateTime? DateReceived { get; set; }
    }
}
