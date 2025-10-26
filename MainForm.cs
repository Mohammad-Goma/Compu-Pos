using Compu_Pos.Data.Context;
using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Services;
using Compu_Pos.Reports.RPT_Views;
using Compu_Pos.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Compu_Pos
{
    public partial class MainForm : Form
    {
        frm_Invoice invoice;
        frm_Unit unit;
        frm_Invoice_Return invoiceReturn;
        frm_Store store;
        frm_Product product;
        frm_Employee employee;
        frm_Branch branch;
        frm_Company company;
        frm_Customer customer;
        frm_Cat cat;
        frm_Delevery delevery;
        frm_Logo logo;
        frm_Purchase purchase;
        frm_Purchase_Return purchaseReturn;
        frm_rpt_Invoice frm_Report_View;
        frm_rpt_purchase _Rpt_Purchase;
        frm_rpt_Profits _Rpt_Profits;
        //frm_SplashForm splashForm;
        frm_price_Checker _Price_Checker;
        frm_RevenueService frm_RevenueService;

        private readonly IConfiguration _configuration;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbl_Invisible();
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            //كود فتح الصفحة ومنع تكرارها
            if (invoice == null)
            {
                var repo = DI.Provider?.GetRequiredService<IProduct_Repo>();
                var repoemp = DI.Provider?.GetRequiredService<IEmployee_Repo>();
                var repocust = DI.Provider?.GetRequiredService<ICustomer_Repo>();
                var repoinv = DI.Provider?.GetRequiredService<Iinvoice_Repo>();
                invoice = new frm_Invoice(repo, repoemp, repocust, repoinv);
                invoice.Show();
            }
            else if (invoice.Visible == true)
            {
                invoice.BringToFront();
                invoice.Focus();
            }
            else
            {
                invoice.Close();
                var repo = DI.Provider?.GetRequiredService<IProduct_Repo>();
                var repoemp = DI.Provider?.GetRequiredService<IEmployee_Repo>();
                var repocust = DI.Provider?.GetRequiredService<ICustomer_Repo>();
                var repoinv = DI.Provider?.GetRequiredService<Iinvoice_Repo>();
                invoice = new frm_Invoice(repo, repoemp, repocust, repoinv);
                invoice.Show();
            }
            invoice.WindowState = FormWindowState.Normal;
            lbl_Invisible();
            lbl_invoice.Visible = true;
        }

        private void btn_units_Click(object sender, EventArgs e)
        {
            try
            {
                //كود فتح الصفحة ومنع تكرارها
                if (unit == null)
                {
                    var repo = DI.Provider?.GetRequiredService<IUnit_Repo>();
                    unit = new frm_Unit(repo!);
                    unit.Show();
                }
                else if (unit.Visible == true)
                {
                    unit.BringToFront();
                    unit.Focus();
                }
                else
                {
                    unit.Close();
                    var repo = DI.Provider?.GetRequiredService<IUnit_Repo>();
                    unit = new frm_Unit(repo!);
                    unit.Show();
                }
                unit.WindowState = FormWindowState.Normal;
                lbl_Invisible();
                lbl_units.Visible = true;
            }
            catch
            {

            }

        }

        private void btn_returninvoice_Click(object sender, EventArgs e)
        {
            try
            {
                //كود فتح الصفحة ومنع تكرارها
                if (invoiceReturn == null)
                {
                    invoiceReturn = new frm_Invoice_Return();
                    invoiceReturn.Show();
                }
                else if (invoiceReturn.Visible == true)
                {
                    invoiceReturn.BringToFront();
                    invoiceReturn.Focus();
                }
                else
                {
                    invoiceReturn.Close();
                    invoiceReturn = new frm_Invoice_Return();
                    invoiceReturn.Show();
                }
                invoiceReturn.WindowState = FormWindowState.Normal;
                lbl_Invisible();
                lbl_returninvoice.Visible = true;
            }
            catch
            {

            }
        }

        private void btn_priceshow_Click(object sender, EventArgs e)
        {
            try
            {
                //كود فتح الصفحة ومنع تكرارها
                if (_Price_Checker == null)
                {
                    var repo = DI.Provider?.GetRequiredService<IProduct_Repo>();
                    _Price_Checker = new frm_price_Checker(repo!);
                    _Price_Checker.Show();
                }
                else if (_Price_Checker.Visible == true)
                {
                    _Price_Checker.BringToFront();
                    _Price_Checker.Focus();
                }
                else
                {
                    _Price_Checker.Close();
                    var repo = DI.Provider?.GetRequiredService<IProduct_Repo>();
                    _Price_Checker = new frm_price_Checker(repo!);
                    _Price_Checker.Show();
                }
                _Price_Checker.WindowState = FormWindowState.Normal;
                lbl_Invisible();
                lbl_priceshow.Visible = true;
            }
            catch
            {

            }
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            try
            {
                //كود فتح الصفحة ومنع تكرارها
                if (purchase == null)
                {
                    var prodrepo = DI.Provider?.GetRequiredService<IProduct_Repo>();
                    var emprepo = DI.Provider?.GetRequiredService<IEmployee_Repo>();
                    var purrepo = DI.Provider?.GetRequiredService<IPurchase_Repo>();
                    var Delivrepo = DI.Provider?.GetRequiredService<IDelevery_Repo>();
                    var prodserv = DI.Provider?.GetRequiredService<ProductService>();
                    purchase = new frm_Purchase(emprepo, purrepo, Delivrepo, prodserv);
                    purchase.Show();
                }
                else if (purchase.Visible == true)
                {
                    purchase.BringToFront();
                    purchase.Focus();
                }
                else
                {
                    purchase.Close();
                    var prodrepo = DI.Provider?.GetRequiredService<IProduct_Repo>();
                    var emprepo = DI.Provider?.GetRequiredService<IEmployee_Repo>();
                    var purrepo = DI.Provider?.GetRequiredService<IPurchase_Repo>();
                    var Delivrepo = DI.Provider?.GetRequiredService<IDelevery_Repo>();
                    var prodserv = DI.Provider?.GetRequiredService<ProductService>();
                    purchase = new frm_Purchase(emprepo, purrepo, Delivrepo, prodserv);
                    purchase.Show();
                }
                purchase.WindowState = FormWindowState.Normal;
                lbl_Invisible();
                lbl_purchase.Visible = true;
            }
            catch
            {

            }
        }

        private void btn_returnpurchase_Click(object sender, EventArgs e)
        {
            try
            {
                //كود فتح الصفحة ومنع تكرارها
                if (purchaseReturn == null)
                {
                    purchaseReturn = new frm_Purchase_Return();
                    purchaseReturn.Show();
                }
                else if (purchaseReturn.Visible == true)
                {
                    purchaseReturn.BringToFront();
                    purchaseReturn.Focus();
                }
                else
                {
                    purchaseReturn.Close();
                    purchaseReturn = new frm_Purchase_Return();
                    purchaseReturn.Show();
                }
                purchaseReturn.WindowState = FormWindowState.Normal;
                lbl_Invisible();
                lbl_return_purchase.Visible = true;
            }
            catch
            {

            }
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            try
            {
                //كود فتح الصفحة ومنع تكرارها
                if (product == null)
                {
                    var prodrepo = DI.Provider?.GetRequiredService<IProduct_Repo>();
                    var prodserv = DI.Provider?.GetRequiredService<ProductService>();
                    if (prodrepo == null || prodserv == null)
                    {
                        MessageBox.Show("فشل في تحميل الخدمات المطلوبة.");
                        return;
                    }

                    product = new frm_Product(prodrepo, prodserv);
                    product?.Show();
                }
                else if (product.Visible == true)
                {
                    product.BringToFront();
                    product.Focus();
                }
                else
                {
                    product.Close();
                    var prodrepo = DI.Provider?.GetRequiredService<IProduct_Repo>();
                    var prodserv = DI.Provider?.GetRequiredService<ProductService>();
                    if (prodrepo == null || prodserv == null)
                    {
                        MessageBox.Show("فشل في تحميل الخدمات المطلوبة.");
                        return;
                    }

                    product = new frm_Product(prodrepo, prodserv);
                    product?.Show();
                }
                product!.WindowState = FormWindowState.Normal;
                lbl_Invisible();
                lbl_products.Visible = true;
            }
            catch
            {

            }
        }

        private void btn_cats_Click(object sender, EventArgs e)
        {
            try
            {
                //كود فتح الصفحة ومنع تكرارها
                if (cat == null)
                {
                    var repo = DI.Provider?.GetRequiredService<ICat_Repo>();
                    var S_repo = DI.Provider?.GetRequiredService<IStore_Repo>();
                    var B_repo = DI.Provider?.GetRequiredService<IBranch_Repo>();
                    cat = new frm_Cat(repo!, S_repo!, B_repo!);
                    cat.Show();
                }
                else if (cat.Visible == true)
                {
                    cat.BringToFront();
                    cat.Focus();
                }
                else
                {
                    cat.Close();
                    var repo = DI.Provider?.GetRequiredService<ICat_Repo>();
                    var S_repo = DI.Provider?.GetRequiredService<IStore_Repo>();
                    var B_repo = DI.Provider?.GetRequiredService<IBranch_Repo>();
                    cat = new frm_Cat(repo!, S_repo!, B_repo!);
                    cat.Show();
                }
                cat.WindowState = FormWindowState.Normal; lbl_Invisible();
                lbl_cats.Visible = true;
            }
            catch
            {

            }
        }

        private void btn_branches_Click(object sender, EventArgs e)
        {
            try
            {
                //كود فتح الصفحة ومنع تكرارها
                if (branch == null)
                {
                    var repo = DI.Provider?.GetRequiredService<IBranch_Repo>();
                    branch = new frm_Branch(repo!);
                    branch.Show();
                }
                else if (branch.Visible == true)
                {
                    branch.BringToFront();
                    branch.Focus();
                }
                else
                {
                    var repo = DI.Provider?.GetRequiredService<IBranch_Repo>();
                    branch.Close(); branch = new frm_Branch(repo!); branch.Show();
                }
                branch.WindowState = FormWindowState.Normal; lbl_Invisible();
                lbl_branches.Visible = true;
            }
            catch
            {

            }
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            try
            {
                var dbContext = new ApplicationDBContext(_configuration);
                frm_RevenueService = new frm_RevenueService(dbContext);


                if (!frm_RevenueService.Visible)
                {
                    // تمرير الـ DbContext الحالي للفورم
                    frm_RevenueService = new frm_RevenueService(dbContext);
                    frm_RevenueService.Show();
                }
                else if (frm_RevenueService.Visible)
                {
                    frm_RevenueService.BringToFront();
                    frm_RevenueService.Focus();
                }

                frm_RevenueService.WindowState = FormWindowState.Normal;

                lbl_Invisible();
                lbl_Customer.Visible = true;
            }
            catch
            {

            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void lbl_Invisible()
        {
            lbl_branches.Visible = false;
            lbl_cats.Visible = false;
            lbl_reports.Visible = false;
            lbl_priceshow.Visible = false;
            lbl_delevery.Visible = false;
            lbl_Company.Visible = false;
            lbl_Emp.Visible = false;
            lbl_Customer.Visible = false;
            lbl_invoice.Visible = false;
            lbl_products.Visible = false;
            lbl_returninvoice.Visible = false;
            lbl_return_purchase.Visible = false;
            lbl_purchase.Visible = false;
            lbl_Symbol.Visible = false;
            lbl_store.Visible = false;
            lbl_units.Visible = false;
        }

        private void btn_delevery_Click(object sender, EventArgs e)
        {
            try
            {
                //كود فتح الصفحة ومنع تكرارها
                if (delevery == null)
                {
                    var repo = DI.Provider?.GetRequiredService<IDelevery_Repo>();
                    var comp = DI.Provider?.GetRequiredService<ICompany_Repo>();
                    delevery = new frm_Delevery(repo!, comp!);
                    delevery.Show();
                }
                else if (delevery.Visible == true)
                {
                    delevery.BringToFront();
                    delevery.Focus();
                }
                else
                {
                    delevery.Close();
                    var repo = DI.Provider?.GetRequiredService<IDelevery_Repo>();
                    var comp = DI.Provider?.GetRequiredService<ICompany_Repo>();
                    delevery = new frm_Delevery(repo!, comp!);
                    delevery.Show();
                }
                delevery.WindowState = FormWindowState.Normal;
                lbl_Invisible();
                lbl_delevery.Visible = true;
            }
            catch
            {

            }
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            try
            {
                //كود فتح الصفحة ومنع تكرارها
                if (customer == null)
                {
                    var repo = DI.Provider?.GetRequiredService<ICustomer_Repo>();
                    customer = new frm_Customer(repo!);
                    customer.Show();
                }
                else if (customer.Visible == true)
                {
                    customer.BringToFront();
                    customer.Focus();
                }
                else
                {
                    customer.Close();
                    var repo = DI.Provider?.GetRequiredService<ICustomer_Repo>();
                    customer = new frm_Customer(repo!);
                    customer.Show();
                }
                customer.WindowState = FormWindowState.Normal;
                lbl_Invisible();
                lbl_Customer.Visible = true;
            }
            catch
            {

            }
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            try
            {
                //كود فتح الصفحة ومنع تكرارها
                if (employee == null)
                {
                    var repo = DI.Provider?.GetRequiredService<IEmployee_Repo>();
                    employee = new frm_Employee(repo!);
                    employee.Show();
                }
                else
                if (employee.Visible == true)
                {
                    employee.BringToFront();
                    employee.Focus();
                }
                else
                {
                    employee.Close();
                    var repo = DI.Provider?.GetRequiredService<IEmployee_Repo>();
                    employee = new frm_Employee(repo!);
                    employee.Show();
                }
                employee.WindowState = FormWindowState.Normal;
                lbl_Invisible();
                lbl_Emp.Visible = true;
            }
            catch
            {

            }
        }

        private void btn_company_Click(object sender, EventArgs e)
        {
            try
            {
                //كود فتح الصفحة ومنع تكرارها
                if (company == null)
                {
                    var repo = DI.Provider?.GetRequiredService<ICompany_Repo>();
                    company = new frm_Company(repo!);
                    company.Show();
                }
                else if (company.Visible == true)
                {
                    company.BringToFront();
                    company.Focus();
                }
                else
                {
                    company.Close();
                    var repo = DI.Provider?.GetRequiredService<ICompany_Repo>();
                    company = new frm_Company(repo!);
                    company.Show();
                }
                company.WindowState = FormWindowState.Normal;
                lbl_Invisible();
                lbl_Company.Visible = true;
            }
            catch
            {

            }
        }

        private void btn_sympole_Click(object sender, EventArgs e)
        {
            try
            {
                //كود فتح الصفحة ومنع تكرارها   
                if (logo == null)
                {
                    logo = new frm_Logo();
                    logo.Show();
                }
                else if (logo.Visible == true)
                {
                    logo.BringToFront();
                    logo.Focus();
                }
                else
                {
                    logo.Close(); logo = new frm_Logo(); logo.Show();
                }
                logo.WindowState = FormWindowState.Normal;
                lbl_Invisible();
                lbl_Symbol.Visible = true;
            }
            catch
            {

            }
        }

        private void btn_store_Click(object sender, EventArgs e)
        {
            try
            {
                //كود فتح الصفحة ومنع تكرارها
                if (store == null)
                {
                    var s_repo = DI.Provider?.GetRequiredService<IStore_Repo>();
                    var b_repo = DI.Provider?.GetRequiredService<IBranch_Repo>();
                    store = new frm_Store(s_repo!, b_repo!);
                    store.Show();
                }
                else if (store.Visible == true)
                {
                    store.BringToFront();
                    store.Focus();
                }
                else
                {
                    var s_repo = DI.Provider?.GetRequiredService<IStore_Repo>();
                    var b_repo = DI.Provider?.GetRequiredService<IBranch_Repo>();
                    store.Close();
                    store = new frm_Store(s_repo!, b_repo!);
                    store.Show();
                }
                store.WindowState = FormWindowState.Normal;
                lbl_Invisible();
                lbl_store.Visible = true;
            }
            catch
            {

            }
        }

        private void btn_report_Invoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (frm_Report_View == null || frm_Report_View.IsDisposed)
                {
                    var dbContext = DI.Provider?.GetRequiredService<ApplicationDBContext>();
                    frm_Report_View = new frm_rpt_Invoice(dbContext);
                    frm_Report_View.Show();
                }
                else
                {
                    if (!frm_Report_View.Visible)
                        frm_Report_View.Show();
                    frm_Report_View.BringToFront();
                    frm_Report_View.WindowState = FormWindowState.Normal;
                    frm_Report_View.Focus();
                }
                lbl_Invisible();
                lbl_Symbol.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء فتح التقرير:\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Purchaces_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Rpt_Purchase == null || _Rpt_Purchase.IsDisposed)
                {
                    var dbContext = DI.Provider?.GetRequiredService<ApplicationDBContext>();
                    _Rpt_Purchase = new frm_rpt_purchase(dbContext);
                    _Rpt_Purchase.Show();
                }
                else
                {
                    if (!_Rpt_Purchase.Visible)
                        _Rpt_Purchase.Show();
                    _Rpt_Purchase.BringToFront();
                    _Rpt_Purchase.WindowState = FormWindowState.Normal;
                    _Rpt_Purchase.Focus();
                }
                lbl_Invisible();
                lbl_Symbol.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء فتح التقرير:\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Revenue_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Rpt_Profits == null || _Rpt_Profits.IsDisposed)
                {
                    var dbContext = DI.Provider?.GetRequiredService<ApplicationDBContext>();
                    _Rpt_Profits = new frm_rpt_Profits(dbContext);
                    _Rpt_Profits.Show();
                }
                else
                {
                    if (!_Rpt_Profits.Visible)
                        _Rpt_Profits.Show();
                    _Rpt_Profits.BringToFront();
                    _Rpt_Profits.WindowState = FormWindowState.Normal;
                    _Rpt_Profits.Focus();
                }
                lbl_Invisible();
                lbl_Symbol.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء فتح التقرير:\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ZeroProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
