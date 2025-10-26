using Compu_Pos.Data.Context;
using Compu_Pos.Data.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Compu_Pos.Reports.RPT_Views
{
    public partial class frm_rpt_purchase : Form
    {
        private readonly ApplicationDBContext _dbContext;

        public frm_rpt_purchase(ApplicationDBContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            DateTime startDt = StartDate.Value.Date;
            DateTime endDt = EndDate.Value.Date;

            var items = _dbContext.PurchaseItems
                .Include(i => i.Purchase) // هنا خطأ
                .Where(i => i.Purchase.PurchaseDate >= startDt && i.Purchase.PurchaseDate <= endDt)
                .Select(i => new PurchaseItemReport
                {
                    Barcode = i.Barcode,
                    ProductName = i.ProductName,
                    Quantity = i.Quantity,
                    UnitCost = i.UnitCost,
                    Discount = i.Discount,
                    TaxRate = i.TaxRate,
                    UnitName = i.UnitName,
                    PurchaseDate = i.Purchase.PurchaseDate,
                    Status = i.Status
                })
                .ToList();

            var report = new PurchaseReportViewModel
            {
                StartDate = startDt,
                EndDate = endDt,
                Items = items
            };

            dgv.DataSource = report.Items;
            lblTotal.Text = $"إجمالي المشتريات: {report.TotalPurchases:C}";
        }
    }
}