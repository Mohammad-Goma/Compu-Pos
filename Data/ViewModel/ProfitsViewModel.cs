using System;
using System.Collections.Generic;
using System.Linq;

namespace Compu_Pos.Data.ViewModel
{
    public class ProfitsViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<ProfitItemReport> Items { get; set; } = new();

        public decimal TotalSales => Items.Sum(i => i.SalesTotal);
        public decimal TotalPurchases => Items.Sum(i => i.PurchaseTotal);
        public decimal TotalProfit => Items.Sum(i => i.Profit);
    }

    public class ProfitItemReport
    {
        public string? Barcode { get; set; }
        public string? ProductName { get; set; }

        public int QuantitySold { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal SalesTotal => QuantitySold * SellingPrice;

        public int QuantityPurchased { get; set; }
        public decimal PurchaseCost { get; set; }
        public decimal PurchaseTotal => QuantityPurchased * PurchaseCost;

        public decimal Profit => SalesTotal - PurchaseTotal;
    }
}