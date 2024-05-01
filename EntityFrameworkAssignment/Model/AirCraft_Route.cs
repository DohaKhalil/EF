using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAssignment.Model
{
    internal class AirCraft_Route
    {
        public AirCraft AirCraft { get; set; }
        public int? ACRId { get; set; }
        public Route Route { get; set; }
        public int RoutId { get; set; }
        public string? Departure { get; set; }
        public int? Num_Of_Pass { get; set; }
        public decimal? Price { get; set; }
        public string Arrival { get; set; }


    }
}
