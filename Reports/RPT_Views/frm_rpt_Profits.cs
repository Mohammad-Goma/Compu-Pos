using Compu_Pos.Data.Context;
using Compu_Pos.Data.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Compu_Pos.Reports.RPT_Views
{
    public partial class frm_rpt_Profits : Form
    {
        private readonly ApplicationDBContext _dbContext;

        public frm_rpt_Profits(ApplicationDBContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            DateTime startDt = StartDate.Value.Date;
            DateTime endDt = EndDate.Value.Date;

            // استخراج بيانات المبيعات
            var sales = _dbContext.InvoiceItems
                .Include(i => i.Invoice)
                .Where(i => i.Invoice.Date >= startDt && i.Invoice.Date <= endDt)
                .GroupBy(i => i.Name ?? "غير معروف")
                .Select(g => new
                {
                    ProductName = g.Key,
                    QuantitySold = g.Sum(x => x.Quantity),
                    SellingPrice = g.Average(x => x.Price_3)
                }).ToList();

            // استخراج بيانات المشتريات
            var purchases = _dbContext.PurchaseItems
                .Include(p => p.Purchase)
                .Where(p => p.Purchase.PurchaseDate >= startDt && p.Purchase.PurchaseDate <= endDt)
                .GroupBy(p => p.ProductName ?? "غير معروف")
                .Select(g => new
                {
                    ProductName = g.Key,
                    QuantityPurchased = g.Sum(x => x.Quantity),
                    PurchaseCost = g.Average(x => x.UnitCost)
                }).ToList();

            // دمج البيانات وحساب الربح
            var profitItems = sales.Select(s =>
            {
                var purchase = purchases.FirstOrDefault(p => p.ProductName == s.ProductName);
                int qtyPurchased = purchase?.QuantityPurchased ?? 0;
                decimal cost = purchase?.PurchaseCost ?? 0;

                return new ProfitItemReport
                {
                    ProductName = s.ProductName,
                    QuantitySold = s.QuantitySold,
                    SellingPrice = s.SellingPrice,
                    QuantityPurchased = qtyPurchased,
                    PurchaseCost = cost
                };
            }).ToList();

            var report = new ProfitsViewModel
            {
                StartDate = startDt,
                EndDate = endDt,
                Items = profitItems
            };

            dgv.DataSource = report.Items;
            lblTotal.Text = $"إجمالي الربح: {report.TotalProfit:C}";
        }
    }
}