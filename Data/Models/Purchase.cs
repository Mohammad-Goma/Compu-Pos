using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Pos.Data.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public string? Notes { get; set; }
        public bool IsPaid { get; set; } = false;
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        public int DeleveryId { get; set; }
        public Delevery? Delevery { get; set; }
        public string? CreatedBy { get; set; } // اسم الموظف الذي أنشأ الفاتورة
        public ICollection<PurchaseItem>? Items { get; set; }
        public decimal TotalAmount => Items?.Sum(item => item.TotalPrice) ?? 0;
        public decimal Discount { get; set; } = 0;
        public decimal TaxRate { get; set; } = 0;
        public decimal NetAmount =>
            (TotalAmount * (1 + TaxRate / 100)) - Discount;
    }
}
