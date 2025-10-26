using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Pos.Data.Models
{
    public class Invoice_ReturnItem
    {
        public int Id { get; set; }
        public string? Parcode { get; set; }
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price_3 { get; set; }
    }
}
