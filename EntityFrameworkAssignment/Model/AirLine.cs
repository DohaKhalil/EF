using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAssignment.Model
{
    internal class AirLine
    {
        [NotMapped]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int Count_Person { get; set; }
        public ICollection<AirCraft> AirCrafts { get; set; }
        public int AirCraftsId { get; set; }

        public ICollection<AirLine_Phone> AirLine_Phones { get; set; }
        public ICollection <Transaction> Transaction { get; set; }
        public int TransactionId { get; set; }
        public ICollection<Employee> Employees { get; set; }
        [ForeignKey("Employee")]
        [InverseProperty("Employee")]
        public int? EmployeeId { get; set; }

    }
}
