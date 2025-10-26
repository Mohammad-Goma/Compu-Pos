using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Pos.Reports
{
    public class RevenueReport
    {
        public decimal TotalSales { get; set; }                 // إجمالي المبيعات
        public decimal TotalSalesReturns { get; set; }          // إجمالي مرتجعات المبيعات
        public decimal TotalPurchases { get; set; }             // إجمالي المشتريات
        public decimal TotalPurchaseReturns { get; set; }       // إجمالي مرتجعات المشتريات
        public decimal NetProfit { get; set; }                  // صافي الربح
    }
}
