using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAssignment.Model
{
    internal class AirCraft
    {
        public int Id { get; set; }
        public int Capsity { get; set; } 
        public string? Model { get; set; }
        public string? Maj_Pailot { get; set; }
        public string? Assistant{ get; set; }
        public string? Host_1 { get; set; }
        public string? Host_2 { get; set; }
        public int AirLineId { get; set; }
        public AirLine  AirLine { get; set;}
        public ICollection<AirCraft_Route> AirCraftRoutes { get; set; }
    }
}
