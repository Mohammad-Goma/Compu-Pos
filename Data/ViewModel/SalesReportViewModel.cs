using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Pos.Data.ViewModel
{
    public class SalesReportViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<InvoiceItemReport> Items { get; set; } = new();
        public decimal TotalSales => Items.Sum(i => i.Total);
    }

    public class InvoiceItemReport
    {
        public string? Parcode { get; set; }
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total => Quantity * Price;
        public DateTime InvoiceDate { get; set; }
    }
}
