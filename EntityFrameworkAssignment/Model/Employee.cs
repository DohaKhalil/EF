using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAssignment.Model
{
    internal class Employee
    {
        [NotMapped]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
        public string? postion { get; set; }
        public  string?  BD_Year { get; set; }
        public string? BD_Month { get; set; }
        public string? BD_Day { get; set; }
        public AirLine? AirLine { get; set; }
        public int? AirLineId { get; set; }
        public ICollection <Emp_Cualification> Emp_Cualification { get; set; }
    }
}
