using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Pos.Data.Models
{
    public class PurchaseInvoice_Return
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; } = DateTime.Now;
        public int SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public ICollection<PurchaseItem>? Items { get; set; }

        public decimal TotalAmount => Items?.Sum(item => item.TotalPrice) ?? 0;

    }

    public class PurchaseItem_Return
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }

        public decimal TotalPrice => Quantity * UnitCost;
    }
}
