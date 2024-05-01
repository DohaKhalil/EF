using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAssignment.Model
{
    internal class Transaction
    {
        public int Id { get; set; }
        public string Discription { get; set; }
        public decimal Amount { get; set; }
        public DateOnly Date { get; set; }
        public int? AirLineId { get; set; }

        public AirLine AirLines { get; set; }

    }
}
