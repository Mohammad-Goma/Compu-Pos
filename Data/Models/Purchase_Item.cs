using System.ComponentModel.DataAnnotations;

namespace Compu_Pos.Data.Models
{
    public class PurchaseItem
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public string? Barcode { get; set; }
        public string? UnitName { get; set; }               // مثل "كرتونة" أو "قطعة"
        public decimal TotalPrice => Quantity * UnitCost;
        public int PurchaseId { get; set; } // المفتاح الأجنبي
        public Purchase? Purchase { get; set; } // خاصية التنقل

        [Range(0, double.MaxValue)]
        public decimal Discount { get; set; }

        [Range(0, 100)]
        public decimal TaxRate { get; set; } = 0;
        public decimal Subtotal => Quantity * UnitCost;
        public string Status { get; set; } = "Pending";     // أو "Paid", "Cancelled"
        public decimal NetPrice => (Quantity * UnitCost) - Discount + (Quantity * UnitCost * TaxRate / 100);
    }
}
