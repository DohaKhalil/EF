using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAssignment.Model
{
    internal class Route
    {
        public int Id { get; set; }
        public string? Distnace { get; set; }
        public string? Distanction { get; set; }
        public string? Orgine { get; set; }
        public string? Classfication { get; set; }
        public ICollection<AirCraft_Route> AirCraftRoutes { get; set; }
    }
}
