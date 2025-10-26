using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Pos.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? JobTitle { get; set; }
        public string? Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

    }
}
