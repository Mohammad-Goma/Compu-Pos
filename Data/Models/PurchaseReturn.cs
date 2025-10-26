using System;
using System.Collections.Generic;

namespace Compu_Pos.Data.Models
{
    public class PurchaseReturn
    {
        public int Id { get; set; }

        public DateTime ReturnDate { get; set; } = DateTime.Now;

        public int PurchaseId { get; set; } // الربط بالفاتورة الأصلية
        public Purchase? Purchase { get; set; }

        public string? Reason { get; set; } // سبب الإرجاع
        public string? ProcessedBy { get; set; } // الموظف الذي نفذ العملية

        public ICollection<Purchase_ReturnItem>? Items { get; set; }

        public decimal TotalRefund => Items?.Sum(item => item.RefundAmount) ?? 0;
    }
}