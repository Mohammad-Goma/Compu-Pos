using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;
using Compu_Pos.Data.Services;
using Microsoft.EntityFrameworkCore;

namespace Compu_Pos.Views
{
    public partial class frm_Purchase : Form
    {
        private readonly IEmployee_Repo _employee_Repo;
        private readonly IPurchase_Repo _purchase_Repo;
        private readonly IDelevery_Repo _delivery_Repo;
        private readonly ProductService _productService;
        private bool isRed = true;
        private bool isEditing = false;
        private bool LetsSearchByBarcode = true;
        private bool LetsSearchByName = true;

        public frm_Purchase(IEmployee_Repo employee_Repo, IPurchase_Repo purchase_Repo, IDelevery_Repo delivery_Repo, ProductService productService)
        {
            InitializeComponent();
            _employee_Repo = employee_Repo;
            _purchase_Repo = purchase_Repo;
            _delivery_Repo = delivery_Repo;
            _productService = productService;
        }

        private async void frm_Purchase_Load(object sender, EventArgs e)
        {
            await LoadFormDataAsync();
        }

        private async Task LoadFormDataAsync()
        {
            try
            {
                DT.Value = DateTime.Now;

                await Get_Name_Emp();
                await Task.Delay(300);

                await Get_Name_Delivery();
                await Task.Delay(300);

                int maxInvoiceId = await _purchase_Repo.GetNextPurchaseNumber();
                txt_Purchase_Num.Text = (maxInvoiceId + 1).ToString();

                //await FillComboBox<Unit>(cbo_unit, _productService.GetUnitsAsync, "Name", "Id");
                //await FillComboBox<Cat>(cbo_Cat, _productService.GetCategoriesAsync, "Name", "Id");
                //await FillComboBox<Store>(cbo_Store, _productService.GetStoresAsync, "Name", "Id");
                //await FillComboBox<Branch>(cbo_Branch, _productService.GetBranchesAsync, "Name", "Id");
                //await FillComboBox<Product>(cbo_ProductName, _productService.GetProductsAsync, "Name", "Id");
            }
            catch { }
        }

        private async Task FillComboBox<T>(ComboBox comboBox, Func<Task<IEnumerable<T>>> getDataFunc, string displayMember, string valueMember)
        {
            var data = await getDataFunc();
            comboBox.DataSource = null;
            comboBox.Items.Clear();
            comboBox.DataSource = data;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.SelectedIndex = -1;
        }

        private async Task Get_Name_Delivery()
        {
            try
            {
                var deliveries = await _delivery_Repo.GetAll(); // تحميل البيانات من الريبو

                cbo_Deleviry.DataSource = null;
                cbo_Deleviry.Items.Clear();

                foreach (var delivery in deliveries)
                {
                    cbo_Deleviry.Items.Add($"{delivery.Name} - {delivery.Company?.Name}");
                }
                cbo_Deleviry.DataSource = deliveries;
                cbo_Deleviry.DisplayMember = "Name";
                cbo_Deleviry.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل أسماء المندوبين: " + ex.Message);
            }
        }

        private async Task Get_Name_Emp()
        {
            try
            {
                var employees = await _employee_Repo.GetAll();

                cbo_Emp.DataSource = null;           // تنظيف المصدر السابق
                cbo_Emp.Items.Clear();               // تنظيف العناصر السابقة

                cbo_Emp.DataSource = employees;      // تعيين المصدر مرة واحدة
                cbo_Emp.DisplayMember = "FullName";  // تحديد الحقل المعروض
                cbo_Emp.ValueMember = "Id";          // اختياري: لو حابب تربط القيمة بمعرّف الموظف
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل أسماء الموظفين: " + ex.Message);
            }
        }

        private async void Barcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (LetsSearchByBarcode)
                {
                    LetsSearchByName = false;
                    string barcode = Barcode.Text.Trim();
                    if (!string.IsNullOrEmpty(barcode))
                    {
                        // Use ProductService
                        var productDetails = await _productService.GetProductDetailsByBarcode(barcode);
                        if (productDetails != null)
                        {
                            Search_Name.Text = productDetails.ProductName!.ToString();
                            Price_1.Text = productDetails.Price_1.ToString();
                            Price_2.Text = productDetails.Price_2.ToString();
                            Pric_3.Text = productDetails.Price_3.ToString();
                            //cbo_unit.Text = string.Empty;

                            //cbo_unit.Text = productDetails.UnitName.ToString();
                            //cbo_unit.SelectedText = productDetails.UnitName!.ToString();
                        }
                    }
                    await Task.Delay(2000);
                    LetsSearchByName = true;
                    Barcode.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while searching: {ex.Message}");
            }
        }

        private void UpdateTotal()
        {
            try
            {
                decimal lastTotal = 0;

                foreach (DataGridViewRow row in DGV.Rows)
                {
                    if (row.Cells[4].Value != null)
                    {
                        if (decimal.TryParse(row.Cells[4].Value.ToString(), out decimal rowTotal))
                        {
                            lastTotal += rowTotal;
                        }
                    }
                }

                Total.Text = lastTotal.ToString("0.00");

                this.BeginInvoke(new Action(() =>
                {
                    if (!string.IsNullOrEmpty(Barcode.Text))
                    {
                        Barcode.Focus();
                        Barcode.SelectAll();
                    }

                    if (!string.IsNullOrEmpty(Search_Name.Text))
                    {
                        Search_Name.Focus();
                        Search_Name.SelectAll();
                    }
                }));
            }
            catch
            {

            }

        }

        private async void AddToDGV_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEditing) return; // تجاهل البحث أثناء التعديل اليدوي

                string word = Barcode.Text.Trim();

                var result = await _purchase_Repo.SearchBarcode(word); // انتظار النتيجة

                DGV.AutoGenerateColumns = false;
                foreach (var product in result)
                {
                    // تحقق إذا كان المنتج موجودًا بالفعل
                    bool found = false;
                    foreach (DataGridViewRow row in DGV.Rows)
                    {
                        if (row.Cells[0].Value?.ToString() == product.Parcode)
                        {
                            // قراءة السعر من العمود 3
                            //decimal d_price = Convert.ToDecimal(row.Cells[2].Value);
                            decimal d_price = Convert.ToDecimal(Pric_3.Text.Trim());

                            int Qtyint = Convert.ToInt32(qty.Text.Trim());
                            if (Qtyint < 1)
                            {
                                Qtyint = 1;
                            }
                            // قراءة الكمية الحالية من العمود 2 وزيادتها
                            int I_qty = Convert.ToInt32(row.Cells[3].Value) + Qtyint;
                            row.Cells[3].Value = I_qty;
                            // حساب الإجمالي الجديد
                            decimal total = d_price * I_qty;
                            row.Cells[4].Value = total;

                            found = true;
                            UpdateTotal();
                            break;
                        }
                    }
                    if (!found)
                    {
                        // إذا لم يكن موجودًا، أضفه بكمية 1
                        //decimal dprice = product.Price_3;
                        decimal dprice = Convert.ToDecimal(Pric_3.Text.Trim());
                        int Qtyint = Convert.ToInt32(qty.Text.Trim());
                        if (Qtyint < 1)
                        {
                            Qtyint = 1;
                        }
                        decimal total = dprice * Qtyint;

                        DGV.Rows.Add(
                            product.Parcode,   // العمود 0
                            product.Name,
                            dprice,             // العمود 1 (السعر)
                            Qtyint,          // العمود 2 (الكمية)
                            total              // العمود 3 (الإجمالي)
                            , "حذف"
                        );
                        UpdateTotal();
                    }
                }
            }
            catch { }
            finally { qty.Text = "1"; }
        }

        private async void Search_Name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (LetsSearchByName)
                {
                    LetsSearchByBarcode = false;
                    string name = Search_Name.Text.Trim();
                    if (!string.IsNullOrEmpty(name))
                    {
                        var productDetails = await _productService.GetProductDetailsByName(name);
                        if (productDetails != null)
                        {
                            Barcode.Text = productDetails.Parcode ?? "";
                            Price_1.Text = productDetails.Price_1.ToString("F2");
                            Price_2.Text = productDetails.Price_2.ToString("F2");
                            Pric_3.Text = productDetails.Price_3.ToString("F2");
                            //cbo_unit.Text = string.Empty;
                            //cbo_unit.SelectedText = productDetails.UnitName ?? "";
                        }
                    }
                    await Task.Delay(2000);
                    LetsSearchByBarcode = true;
                    Search_Name.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء البحث: {ex.Message}");
            }
        }

        private void NumericOnly(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // السماح بالأرقام، Backspace، و النقطة العشرية
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            // منع أكثر من نقطة عشرية واحدة
            if (e.KeyChar == '.' && txt != null && txt.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void Price_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericOnly(sender, e);
        }

        private void Price_2_KeyPress(object sender, KeyPressEventArgs e)
        {

            NumericOnly(sender, e);
        }

        private void Pric_3_KeyPress(object sender, KeyPressEventArgs e)
        {

            NumericOnly(sender, e);
        }

        private void qty_KeyPress(object sender, KeyPressEventArgs e)
        {

            NumericOnly(sender, e);
        }

        private void Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericOnly(sender, e);
        }

        private void Pay_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericOnly(sender, e);
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            try
            {
                // التحقق من صحة البيانات الأساسية
                if (string.IsNullOrWhiteSpace(Barcode.Text) || DGV.Rows.Count == 0)
                {
                    MessageBox.Show("يرجى إدخال بيانات المورد والأصناف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // تحديد حالة الدفع حسب نوع الفاتورة
                bool isPaid = false;
                if (cbo_inv_Type.Text == "نقدي")
                    isPaid = true;

                // إنشاء كيان الفاتورة
                var purchase = new Purchase
                {
                    Notes = cbo_inv_Type.SelectedText,
                    IsPaid = isPaid,
                    PurchaseDate = DT.Value,
                    DeleveryId = (int)cbo_Deleviry.SelectedValue,
                    CreatedBy = cbo_Emp.SelectedText, // أو اسم الموظف من جلسة الدخول
                    Discount = decimal.TryParse(Discount.Text, out var discount) ? discount : 0,
                    //TaxRate = decimal.TryParse(tax.Text, out var taxRate) ? taxRate : 0,
                    Items = new List<PurchaseItem>()
                };

                // تعبئة الأصناف من DataGridView
                foreach (DataGridViewRow row in DGV.Rows)
                {
                    if (row.IsNewRow) continue;

                    var item = new PurchaseItem
                    {
                        ProductName = row.Cells["name"].Value?.ToString(),
                        Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                        UnitCost = Convert.ToDecimal(row.Cells["Price_3"].Value),
                        Barcode = row.Cells["Parcode"].Value?.ToString(),
                        //UnitName = row.Cells["UnitName"].Value?.ToString(),
                        //Discount = Convert.ToDecimal(row.Cells["Discount"].Value),
                        //TaxRate = Convert.ToDecimal(row.Cells["TaxRate"].Value),
                        Status = "Pending"
                    };

                    purchase.Items.Add(item);
                }

                await _purchase_Repo.Add(purchase);

                MessageBox.Show("تم حفظ فاتورة المشتريات بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm(); // دالة لتفريغ النموذج بعد الحفظ
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الحفظ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            // تفريغ الحقول النصية
            //txtNotes.Clear();
            Discount.Text = "0";
            //tax.Text = "0";
            Barcode.Text = string.Empty;

            // إعادة تعيين القيم الافتراضية
            cbo_inv_Type.SelectedIndex = -1;
            //chkIsPaid.Checked = false;
            DT.Value = DateTime.Now;
            cbo_Deleviry.SelectedIndex = -1;
            cbo_Emp.SelectedIndex = -1;
            // تفريغ جدول الأصناف
            DGV.Rows.Clear();

            // إعادة ضبط حالة التعديل
            isEditing = false;
            Total.Text = "0";
            Discount.Text = "0";
            Last_total.Text = "0";
            Pay.Text = "0";
            Rest.Text = "0";
            // إعادة ضبط الرسائل أو التنبيهات إن وجدت
            // lblStatus.Text = "";
        }

        private void Discount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Discount.Text) || Discount.Text == "")
            {
                Discount.Text = "0";
                Discount.Focus();
                Discount.SelectAll();
                flashTimer.Stop();
                return;
            }
            else
            {
                DiscountEvent();
                //Paying();
            }
        }

        private void Pay_TextChanged(object sender, EventArgs e)
        {
            Paying();
        }

        private void Paying()
        {

            try
            {
                if (string.IsNullOrEmpty(Pay.Text))
                {
                    Pay.Text = "0";
                    Rest.Text = "0";
                    Pay.Focus();
                    Pay.SelectAll();
                    //Last_total.BackColor = Color.Red;
                    return;
                }
                else
                {
                    decimal rst = decimal.Parse(Rest.Text.Trim());
                    decimal lst_tot = decimal.Parse(Last_total.Text.Trim());
                    decimal paying = decimal.Parse(Pay.Text.Trim());
                    if (paying == 0 || string.IsNullOrEmpty(Pay.Text))
                    {
                        //Rest.BackColor = Color.White;
                        Rest.Text = "0";
                        return;
                    }
                    else
                    if (paying > lst_tot)
                    {
                        rst = paying - lst_tot;
                        Rest.Text = rst.ToString();
                        //Rest.BackColor = Color.Yellow;
                        //Last_total.BackColor = Color.White;
                        flashTimer.Stop();
                        //Rest.BackColor = Color.White;
                        return;
                    }
                    else
                    if (paying < lst_tot)
                    {
                        rst = paying - lst_tot;
                        Rest.Text = rst.ToString();
                        //Rest.BackColor = Color.Red;

                        flashTimer.Interval = 600; // مدة الوميض بالمللي ثانية
                        flashTimer.Start();

                        return;

                    }
                    if (paying == lst_tot)
                    {
                        Rest.Text = "0";
                        //Rest.BackColor = Color.White;

                        flashTimer.Stop();
                        //Last_total.BackColor = Color.White;

                        return;

                    }
                }
            }
            catch { }
            finally
            {
            }
        }

        private void Total_TextChanged(object sender, EventArgs e)
        {
            DiscountEvent();
        }

        private void DiscountEvent()
        {
            try
            {
                Last_total.Text = Total.Text.Trim();
                decimal tot = decimal.Parse(Total.Text.Trim());
                decimal disc = decimal.Parse(Discount.Text.Trim());
                decimal pay = decimal.Parse(Pay.Text.Trim());
                decimal lstTot;
                decimal rst;

                if (string.IsNullOrEmpty(Discount.Text))
                {
                    Discount.Text = "0";
                    Discount.SelectAll();
                    Last_total.Text = Total.ToString();
                    flashTimer.Stop();
                    return;
                }
                else
                   if (!string.IsNullOrEmpty(Discount.Text))
                {

                    lstTot = tot - disc;
                    Last_total.Text = lstTot.ToString();
                    rst = pay - lstTot;
                    Rest.Text = rst.ToString();
                    flashTimer.Stop();
                }
            }
            catch
            {

            }

        }

        private void flashTimer_Tick(object sender, EventArgs e)
        {
            if (isRed)
                Last_total.BackColor = Color.White;
            else
                Last_total.BackColor = Color.Red;

            isRed = !isRed;
        }

        private void cbo_ProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // التأكد من أن المستخدم ضغط على زر الحذف
            if (e.ColumnIndex == DGV.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                //  تأكيد الحذف (اختياري)
                DialogResult result = MessageBox.Show("هل تريد حذف هذا الصف؟", "تأكيد الحذف", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DGV.Rows.RemoveAt(e.RowIndex);
                    UpdateTotal();
                }
            }
        }

        private void Barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericOnly(sender,e);
        }
    }
}
