using Compu_Pos.Data.Context;
using Compu_Pos.Reports;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compu_Pos.Views
{
    public partial class frm_RevenueService : Form
    {
        private readonly ApplicationDBContext _db;

        public frm_RevenueService(ApplicationDBContext Context)
        {
            InitializeComponent();
            _db = Context;
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            // استدعاء الدالة وتخزين النتيجة
            var report = GetRevenueReport(startDate.Value, endDate.Value);

            // تعبئة الحقول بالقيم
            TotalSales.Text = report.TotalSales.ToString("N2");              // إجمالي المبيعات
            TotalSalesReturns.Text = report.TotalSalesReturns.ToString("N2");// إجمالي مرتجعات المبيعات
            TotalPurchases.Text = report.TotalPurchases.ToString("N2");      // إجمالي المشتريات
            TotalPurchaseReturns.Text = report.TotalPurchaseReturns.ToString("N2"); // إجمالي مرتجعات المشتريات
            NetProfit.Text = report.NetProfit.ToString("N2");                // صافي الربح
        }

        public RevenueReport GetRevenueReport(DateTime startDate, DateTime endDate)
        {
            // إجمالي المبيعات
            //var totalSales = _db.Invoices
            //    .Where(inv => inv.Date >= startDate && inv.Date <= endDate)
            //    .Include(inv => inv.Items) // مهم لجلب العناصر
            //    .AsEnumerable() // التحويل للذاكرة
            //    .Sum(inv => inv.Items.Sum(i => i.Price_3 * i.Quantity));

            //// إجمالي مرتجعات المبيعات
            //var totalSalesReturns = _db.InvoiceReturns
            //    .Where(ret => ret.Date >= startDate && ret.Date <= endDate)
            //    .SelectMany(ret => ret.ReturnItems)
            //    .Sum(i => i.Price_3 * i.Quantity);

            //// إجمالي المشتريات
            //var totalPurchases = _db.Purchases
            //    .Where(p => p.PurchaseDate >= startDate && p.PurchaseDate <= endDate)
            //    .Select(p => p.Items.Sum(i => i.UnitCost * i.Quantity))
            //    .DefaultIfEmpty(0)
            //    .Sum();

            //// إجمالي مرتجعات المشتريات
            //var totalPurchaseReturns = _db.PurchaseReturns
            //    .Where(pr => pr.ReturnDate >= startDate && pr.ReturnDate <= endDate)
            //    .Select(pr => pr.Items.Sum(i => i.UnitCost * i.ReturnedQuantity))
            //    .DefaultIfEmpty(0)
            //    .Sum();

            //// صافي الربح
            //var netProfit = (totalSales - totalSalesReturns) - (totalPurchases - totalPurchaseReturns);

            return new RevenueReport
            {
                //    TotalSales = totalSales,
                //    TotalSalesReturns = totalSalesReturns,
                //    TotalPurchases = totalPurchases,
                //    TotalPurchaseReturns = totalPurchaseReturns,
                //    NetProfit = netProfit
            };
        }
    }
}
