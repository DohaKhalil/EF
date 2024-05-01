using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAssignment.Model
{
    internal class AirLine_Phone
    {
       public int AirLineId { get; set; }
        public double phone { get; set; }
        public AirLine AirLinesPh { get; set; }
    }
}
