using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Pos.Data.Models
{
    public class Purchase_ReturnItem
    {
        public int Id { get; set; }

        public int PurchaseItemId { get; set; } // الربط بالعنصر الأصلي
        public PurchaseItem? PurchaseItem { get; set; }

        public int ReturnedQuantity { get; set; }

        public decimal UnitCost => PurchaseItem?.UnitCost ?? 0;

        public decimal RefundAmount => ReturnedQuantity * UnitCost;

    }
}
