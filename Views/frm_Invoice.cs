using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;

namespace Compu_Pos.Views
{
    public partial class frm_Invoice : Form
    {
        private readonly IProduct_Repo _product_Repo;
        private readonly IEmployee_Repo _employee_Repo;
        private readonly ICustomer_Repo _cutomer_Repo;
        private readonly Iinvoice_Repo _invoice_Repo;
        private bool isEditing = false;
        private bool isRed = true;
        private bool LetsSearchByName = false;
        private bool LetsSearchByBarcode = false;
        private bool isLoaded = false;
        private bool isComboLoaded = false;
        string Barcode;

        public frm_Invoice(IProduct_Repo product_Repo, IEmployee_Repo employee_Repo, ICustomer_Repo cutomer_Repo, Iinvoice_Repo invoice_Repo)
        {
            InitializeComponent();
            _product_Repo = product_Repo;
            _employee_Repo = employee_Repo;
            _cutomer_Repo = cutomer_Repo;
            _invoice_Repo = invoice_Repo;
        }

        private async void frm_Invoice_Load(object sender, EventArgs e)
        {
            isLoaded = false;

            CBO_Name.Enter += new EventHandler(CBO_Name_Enter);
            CBO_Name.SelectedIndexChanged += new EventHandler(CBO_Name_SelectedIndexChanged);
            //CBO_Name.KeyUp += CBO_Name_KeyUp;

            DT.Value = DateTime.Now;
            await Get_Name_Emp();
            await Task.Delay(500);
            await Get_Name_Cust();
            await Task.Delay(500);

            int maxInvoiceId = await GetMaxInvoiceIdAsync();
            txt_Invoice_Num.Text = (maxInvoiceId + 1).ToString();

            await LoadProductNamesAsync();
            isLoaded = true;

        }

        private async Task<int> GetMaxInvoiceIdAsync()
        {
            try
            {
                return await _invoice_Repo.GetNextInvoiceNumber();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب رقم الفاتورة الأعلى: " + ex.Message);
                return 0;
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

        private async Task Get_Name_Cust()
        {
            try
            {
                var customers = await _cutomer_Repo.GetAll();

                cbo_Cust.DataSource = null;           // تنظيف المصدر السابق
                cbo_Cust.Items.Clear();               // تنظيف العناصر السابقة
                foreach (var cust in customers)
                {
                    cbo_Cust.Items.Add(cust.FullName);
                }

                //cbo_Cust.DataSource = customers;      // تعيين المصدر مرة واحدة
                //cbo_Cust.DisplayMember = "FullName";  // تحديد الحقل المعروض
                //cbo_Cust.ValueMember = "Id";          // اختياري: لو حابب تربط القيمة بمعرّف الموظف
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل أسماء العملاء: " + ex.Message);
            }
        }

        private void DGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //isEditing = false;
            //DGV_CellValueChanged(sender, e); // إعادة استخدام نفس الدالة
        }

        private async void Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Search_Parcode.Text))
                {
                    var results = await _product_Repo.SearchParcode(Search_Parcode.Text);
                    var result = results.FirstOrDefault();
                    if (result != null)
                    {
                        Barcode = Search_Parcode.Text.Trim();
                        string name = result.Name.ToString();
                        decimal price = Convert.ToDecimal(result.Price_3.ToString());
                        int qt = int.TryParse(result.Quantity.ToString(), out int q) ? q : 1;
                        decimal totals = price * qt;

                        // تحقق إذا كان المنتج موجودًا بالفعل 
                        bool found = false;
                        foreach (DataGridViewRow row in DGV.Rows)
                        {
                            if (row.Cells[0].Value?.ToString() == Barcode)
                            {
                                // قراءة السعر من العمود 3
                                decimal d_price = Convert.ToDecimal(row.Cells[2].Value);
                                // قراءة الكمية الحالية من العمود 2 وزيادتها
                                int I_qty = Convert.ToInt32(row.Cells[3].Value) + 1;
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
                            DGV.Rows.Add(
                                Barcode,   // العمود 0
                                name,      // العمود 1
                                price,     // العمود 2
                                qt,        // العمود 3
                                totals,    // العمود 4
                                "حذف"      // العمود 5
                            );
                            UpdateTotal();
                        }
                    }
                }
            }
            catch { }
            finally
            {
                Barcode = null;
                txt_Price_3.Text = "";
                qty.Text = "1";
                //if (LetsSearchByBarcode) Search_Parcode.SelectAll();
                //else
                //if (LetsSearchByName) CBO_Name.SelectAll();
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
            }
            catch { }
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

        private void flashTimer_Tick(object sender, EventArgs e)
        {
            if (isRed)
                Last_total.BackColor = Color.White;
            else
                Last_total.BackColor = Color.Red;

            isRed = !isRed;
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

        private void DGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //if (DGV.CurrentCell.ColumnIndex == 2 || DGV.CurrentCell.ColumnIndex == 3)
            //{
            //    TextBox txt = e.Control as TextBox;
            //    if (txt != null)
            //    {
            //        // إزالة أي حدث سابق لتجنب التكرار
            //        txt.KeyPress -= NumericOnly_KeyPress!;
            //        txt.KeyPress += NumericOnly_KeyPress!;
            //    }
            //}
        }

        private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام، Backspace، و النقطة العشرية
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // منع أكثر من نقطة عشرية واحدة
            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.' && txt != null && txt.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام، Backspace، و النقطة العشرية
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // منع أكثر من نقطة عشرية واحدة
            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.' && txt != null && txt.Text.Contains("."))
            {
                e.Handled = true;
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
                    UpdateTotal();
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
                    UpdateTotal();
                }
            }
            catch
            {

            }

        }

        private void DGV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DiscountEvent();
        }

        private void DGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    // تأكد أن التعديل تم في عمود الكمية فقط
            //    if (e.ColumnIndex == 4) // عمود الكمية
            //    {
            //        var row = DGV.Rows[e.RowIndex];
            //        if (row.Cells[2].Value != null && row.Cells[3].Value != null)
            //        {
            //            decimal price = Convert.ToDecimal(row.Cells[2].Value);
            //            int qty = Convert.ToInt32(row.Cells[3].Value);
            //            decimal total = price * qty;
            //            row.Cells[4].Value = total;
            //        }
            //        UpdateTotal(); // تحديث الإجمالي الكلي
            //    }
            //}
            //catch {}
        }

        private void DGV_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //isEditing = true;
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // التأكد من أن المستخدم ضغط على زر الحذف
                if (e.ColumnIndex == DGV.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    // تأكيد الحذف (اختياري)
                    DialogResult result = MessageBox.Show("هل تريد حذف هذا الصف؟", "تأكيد الحذف", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        DGV.Rows.RemoveAt(e.RowIndex);
                        UpdateTotal();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //private void ClearForm()
        //{
        // تفريغ الحقول النصية
        //txtNotes.Clear();
        //Discount.Text = "0";
        //tax.Text = "0";
        //b.Clear();

        // إعادة تعيين القيم الافتراضية
        //cbo_inv_Type.SelectedIndex = -1;
        //chkIsPaid.Checked = false;
        //DT.Value = DateTime.Now;
        //cbo_Deleviry.SelectedIndex = -1;
        //cbo_Emp.SelectedIndex = -1;
        // تفريغ جدول الأصناف
        //DGV.Rows.Clear();

        // إعادة ضبط حالة التعديل
        //isEditing = false;
        //Total.Text = string.Empty;
        //Discount.Text = string.Empty;
        //Last_total.Text = string.Empty;
        //Pay.Text = string.Empty;
        //Rest.Text = string.Empty;
        //}

        private void Last_total_TextChanged(object sender, EventArgs e)
        {
            //decimal lst_tot = decimal.Parse(Last_total.Text.Trim());
            //decimal pay = decimal.Parse(Pay.Text.Trim());
            //if (lst_tot > pay)
            //{
            //    Last_total.BackColor = Color.Red;
            //}
        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                // إنشاء كائن الفاتورة
                Invoice invoice = new Invoice
                {
                    CustomerName = cbo_Cust.Text,
                    Emp_Name = cbo_Emp.Text,
                    Date = DT.Value,
                    Items = new List<InvoiceItem>()
                };
                // استخراج العناصر من DataGridView
                foreach (DataGridViewRow row in DGV.Rows)
                {
                    if (row.IsNewRow) continue;
                    InvoiceItem item = new InvoiceItem
                    {
                        Parcode = row.Cells["Parcode"].Value?.ToString(),
                        Name = row.Cells["Name"].Value?.ToString(),
                        Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                        Price_3 = Convert.ToDecimal(row.Cells["Price_3"].Value)
                    };
                    invoice.Items.Add(item);
                }
                // حفظ الفاتورة
                await _invoice_Repo.Add(invoice);
                MessageBox.Show("تم حفظ الفاتورة بنجاح ✅", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // إعادة تعيين ComboBox
                cbo_Cust.SelectedIndex = -1;
                cbo_Emp.SelectedIndex = -1;
                cbo_inv_Type.SelectedIndex = -1;
                Search_Parcode.Text = string.Empty;
                CBO_Name.Text = string.Empty;
                Total.Text = "0";
                Discount.Text = "0";
                Last_total.Text = "0";
                Pay.Text = "0";
                Rest.Text = "0";
                Rest.BackColor = Color.White;
                DT.Value = DateTime.Now;
                // إعادة تعيين DataGridView
                DGV.Rows.Clear();
                int maxInvoiceId = await GetMaxInvoiceIdAsync();
                txt_Invoice_Num.Text = (maxInvoiceId + 1).ToString();       // مثال: عرض الرقم التالي في Label
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحفظ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddToDGV_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(CBO_Name.Text))
                {
                    string name = CBO_Name.Text.Trim();
                    decimal price = Convert.ToDecimal(txt_Price_3.Text.Trim());
                    decimal qt = Convert.ToDecimal(qty.Text.Trim());
                    decimal totals = price * qt;
                    // تحقق إذا كان المنتج موجودًا بالفعل 
                    //bool found = false;
                    //foreach (DataGridViewRow row in DGV.Rows)
                    //{
                    //    if (row.Cells[0].Value?.ToString() == Barcode)
                    //    {
                    //        // قراءة السعر من العمود 3
                    //        decimal d_price = Convert.ToDecimal(row.Cells[2].Value);
                    //        // قراءة الكمية الحالية من العمود 2 وزيادتها
                    //        int I_qty = Convert.ToInt32(row.Cells[3].Value) + 1;
                    //        row.Cells[3].Value = I_qty;
                    //        // حساب الإجمالي الجديد
                    //        decimal total = d_price * I_qty;
                    //        row.Cells[4].Value = total;
                    //        found = true;
                    //        UpdateTotal();
                    //        break;
                    //    }
                    //}
                    //if (!found)
                    //{
                    DGV.Rows.Add(
                        Barcode,   // العمود 0
                        name,      // العمود 1
                        price,     // العمود 2
                        qt,        // العمود 3
                        totals,    // العمود 4
                        "حذف"      // العمود 5
                    );
                    UpdateTotal();
                    //}
                }
            }
            catch { }
            finally
            {
                Barcode = null;
                txt_Price_3.Text = string.Empty;
                qty.Text = "1";
                CBO_Name.SelectAll();
            }
        }

        private void CBO_Name_Enter(object sender, EventArgs e)
        {
            LetsSearchByName = true;
        }

        private async void CBO_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (isEditing) return;                      // تجاهل البحث أثناء التعديل اليدوي
                DGV.AutoGenerateColumns = false;

                if (LetsSearchByName)
                {
                    LetsSearchByBarcode = false;
                    string name = CBO_Name.SelectedItem?.ToString().Trim();
                    if (!string.IsNullOrEmpty(name))
                    {
                        var results = await _product_Repo.SearchName(name);
                        var result = results.FirstOrDefault();
                        if (result != null)
                        {
                            Barcode = result.Parcode ?? "";
                            txt_Price_3.Text = result.Price_3.ToString("F2");
                            qty.Text = result.Quantity.ToString("F2");
                        }
                    }
                }
            }
            catch { }
        }

        private void CBO_Name_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private async Task LoadProductNamesAsync()
        {
            var products = await _product_Repo.SearchName();
            if (products.Any())
            {
                // إعداد الإكمال التلقائي
                AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
                autoCompleteCollection.AddRange(products.Select(p => p.Name).ToArray());

                CBO_Name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                CBO_Name.AutoCompleteSource = AutoCompleteSource.CustomSource;
                CBO_Name.AutoCompleteCustomSource = autoCompleteCollection;

                // تحديث عناصر ComboBox
                CBO_Name.Items.Clear();
                foreach (var product in products)
                {
                    CBO_Name.Items.Add(product.Name);
                }
            }
        }

        private async void CBO_Name_DropDown(object sender, EventArgs e)
        {
            if (!isLoaded || isEditing || isComboLoaded) return;

            isComboLoaded = true;
            await LoadProductNamesAsync();
        }

        private void Search_Parcode_Enter(object sender, EventArgs e)
        {
            LetsSearchByBarcode = true;
        }

    }
}
