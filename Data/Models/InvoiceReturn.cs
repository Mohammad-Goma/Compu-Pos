using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Pos.Data.Models
{
    public class InvoiceReturn
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string? CustomerName { get; set; }
        public string? Emp_Name { get; set; }

        public ICollection<Invoice_ReturnItem>? ReturnItems { get; set; }

    }
}
