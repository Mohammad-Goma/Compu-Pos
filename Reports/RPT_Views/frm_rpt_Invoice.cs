using Compu_Pos.Data.Context;
using Compu_Pos.Data.ViewModel;
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

namespace Compu_Pos.Reports.RPT_Views
{
    public partial class frm_rpt_Invoice : Form
    {
        private readonly ApplicationDBContext dbContext;
        public frm_rpt_Invoice(ApplicationDBContext _dbContext)
        {
            InitializeComponent();
            dbContext = _dbContext;
        }   // داخل الحدث الخاص بالزر

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            DateTime startDt = StartDate.Value.Date;
            DateTime endDt = EndDate.Value.Date;
            var items = dbContext.InvoiceItems
                .Include(i => i.Invoice)
                .Where(i => i.Invoice.Date >= startDt && i.Invoice.Date <= endDt)
                .Select(i => new InvoiceItemReport
                {
                    Parcode = i.Parcode,
                    Name = i.Name,
                    Quantity = i.Quantity,
                    Price = i.Price_3,
                    InvoiceDate = i.Invoice.Date
                }).ToList();

            var report = new SalesReportViewModel
            {
                StartDate = startDt, EndDate = endDt, Items = items
            };
            dgv.DataSource = report.Items;
            lblTotal.Text = "{report.TotalSales:C}";
        }
    }
}
