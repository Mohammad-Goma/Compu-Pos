using System;
using System.Collections.Generic;
using System.Linq;

namespace Compu_Pos.Data.ViewModel
{
    public class PurchaseReportViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<PurchaseItemReport> Items { get; set; } = new();
        public decimal TotalPurchases => Items.Sum(i => i.TotalPrice);
        public decimal TotalNetAmount => Items.Sum(i => i.NetPrice);
    }

    public class PurchaseItemReport
    {
        public string? Barcode { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public decimal Discount { get; set; }
        public decimal TaxRate { get; set; }
        public string? UnitName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Status { get; set; } = "Pending";

        public decimal TotalPrice => Quantity * UnitCost;
        public decimal NetPrice => (Quantity * UnitCost) - Discount + (Quantity * UnitCost * TaxRate / 100);
    }
}