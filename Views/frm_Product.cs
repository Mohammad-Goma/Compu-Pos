using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;
using Compu_Pos.Data.Services;

namespace Compu_Pos.Views
{
    public partial class frm_Product : Form
    {
        private readonly IProduct_Repo _productRepo;
        private readonly ProductService _productService;

        public frm_Product(IProduct_Repo prodrepo, ProductService prodserv)
        {
            InitializeComponent();
            _productRepo = prodrepo;
            _productService = prodserv;
        }
   
        private async void Product_Load(object sender, EventArgs e)
        {
            await FillComboBox<Unit>(cbo_units, _productService.GetUnitsAsync, "Name", "Id");
            await FillComboBox<Cat>(cbo_cats, _productService.GetCategoriesAsync, "Name", "Id");
            await FillComboBox<Store>(cbo_stores, _productService.GetStoresAsync, "Name", "Id");
            await FillComboBox<Branch>(cbo_branches, _productService.GetBranchesAsync, "Name", "Id");
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_id.Text))
            {
                AddProductAsync();
            }
            else
            {
                int id = Convert.ToInt32(txt_id.Text.Trim());
                UpdateProductAsync(id);
            }
        }

        private async void AddProductAsync()
        {
            if (_productRepo == null)
            {
                MessageBox.Show("خدمة المنتج غير مهيأة بشكل صحيح.", "خطأ في التهيئة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var prod = new Product
                {
                    Name = txt_name.Text,
                    Parcode = txt_Parcode.Text.Trim(),
                    Price_1 = decimal.Parse(txt_price1.Text.Trim()),
                    Price_2 = decimal.Parse(txt_price2.Text.Trim()),
                    Price_3 = decimal.Parse(txt_price3.Text.Trim()),
                    Quantity = decimal.Parse(txt_qty.Text.Trim()),
                    UnitId = Convert.ToInt32(cbo_units.SelectedValue),
                    CatId = Convert.ToInt32(cbo_cats.SelectedValue),
                    StoreId = Convert.ToInt32(cbo_stores.SelectedValue),
                    BranchId = Convert.ToInt32(cbo_branches.SelectedValue)
                };
                await _productRepo.Add(prod);
                MessageBox.Show("🎉 تم الحفظ بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء عملية الحفظ:\n{ex.Message}", "خطأ غير متوقع", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void UpdateProductAsync(int id)
        {
            var newProduct = new Product
            {
                Id = id,
                Name = txt_name.Text,
                Parcode = txt_Parcode.Text.Trim(),
                Price_1 = decimal.Parse(txt_price1.Text.Trim()),
                Price_2 = decimal.Parse(txt_price2.Text.Trim()),
                Price_3 = decimal.Parse(txt_price3.Text.Trim()),
                Quantity = decimal.Parse(txt_qty.Text.Trim()),
                UnitId = Convert.ToInt32(cbo_units.SelectedValue),
                CatId = Convert.ToInt32(cbo_cats.SelectedValue),
                StoreId = Convert.ToInt32(cbo_stores.SelectedValue),
                BranchId = Convert.ToInt32(cbo_branches.SelectedValue)
            };
            await _productRepo!.Update(id, newProduct);
            MessageBox.Show("تم التعديل بنجاح .");
        }

        private async void Delete(int id)
        {
            await _productRepo!.Delete(id);
            MessageBox.Show("تم الحذف بنجاح."); // “Deleted successfully.”
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_id.Text, out int id))
            {
                Delete(id);
            }
            else
            {
                MessageBox.Show("يرجى إدخال معرف صالح.");
            }
        }

        private void ClearTextBoxes(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (ctrl.HasChildren)
                {
                    ClearTextBoxes(ctrl);
                }
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
        }

        private async void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string input = txt_search.Text.Trim();
                if (string.IsNullOrWhiteSpace(input)) return;

                var keyword = input.Split('-')[0].Trim(); // البحث بالباركود أو جزء منه
                var result = (await _productRepo.Search(keyword)).FirstOrDefault();

                if (result != null)
                {
                    txt_id.Text = result.Id.ToString();
                    txt_name.Text = result.Name;
                    txt_Parcode.Text = result.Parcode;
                    txt_price1.Text = result.Price_1.ToString();
                    txt_price2.Text = result.Price_2.ToString();
                    txt_price3.Text = result.Price_3.ToString();
                    txt_qty.Text = result.Quantity.ToString();
                    cbo_branches.Text = result.BranchId.ToString();
                    cbo_cats.Text = result.CatId.ToString();
                    cbo_stores.Text = result.StoreId.ToString();
                    cbo_units.Text = result.UnitId.ToString();
                }
            }
            catch { }
            finally
            {
                lst_Search();
            }
        }

        private async Task lst_Search()
        {
            try
            {

                string keyword = txt_search.Text.Trim();

                if (string.IsNullOrWhiteSpace(keyword))
                {
                    lstbox.Visible = false;
                    return;
                }

                var results = await _productRepo.Search(keyword);

                lstbox.Items.Clear();

                foreach (var item in results)
                {
                    lstbox.Items.Add($"{item.Parcode} - {item.Name}");
                }

                lstbox.Visible = lstbox.Items.Count > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void hid_pri_1_Click(object sender, EventArgs e)
        {
            if (txt_price1.UseSystemPasswordChar)
            {
                // إذا كان النص مخفي، نظهره
                txt_price1.UseSystemPasswordChar = false;
            }
            else
            {
                // إذا كان النص ظاهر، نخفيه
                txt_price1.UseSystemPasswordChar = true;
            }
        }

        private void hid_pri_2_Click(object sender, EventArgs e)
        {
            if (txt_price2.UseSystemPasswordChar)
            {
                // إذا كان النص مخفي، نظهره
                txt_price2.UseSystemPasswordChar = false;
            }
            else
            {
                // إذا كان النص ظاهر، نخفيه
                txt_price2.UseSystemPasswordChar = true;
            }
        }

        private void hid_pri_3_Click(object sender, EventArgs e)
        {

            if (txt_price3.UseSystemPasswordChar)
            {
                // إذا كان النص مخفي، نظهره
                txt_price3.UseSystemPasswordChar = false;
            }
            else
            {
                // إذا كان النص ظاهر، نخفيه
                txt_price3.UseSystemPasswordChar = true;
            }
        }

        private void txt_price1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام (0-9)، نقطة عشرية، أو مفتاح الحذف (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // منع الإدخال
            }

            // السماح بنقطة عشرية واحدة فقط
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

        }

        private void txt_price2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام (0-9)، نقطة عشرية، أو مفتاح الحذف (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // منع الإدخال
            }

            // السماح بنقطة عشرية واحدة فقط
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

        }

        private void txt_price3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام (0-9)، نقطة عشرية، أو مفتاح الحذف (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // منع الإدخال
            }

            // السماح بنقطة عشرية واحدة فقط
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام (0-9)، نقطة عشرية، أو مفتاح الحذف (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // منع الإدخال
            }

            // السماح بنقطة عشرية واحدة فقط
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private async void lst_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstbox.SelectedItem == null)
                return;

            string selectedText = lstbox.SelectedItem.ToString()!;
            string selectedParcode = selectedText.Split('-')[0].Trim();

            var product = (await _productRepo.Search(selectedParcode)).FirstOrDefault();

            if (product != null)
            {
                txt_search.Text = selectedText;
                txt_name.Text = product.Name;
                txt_id.Text = product.Id.ToString();
                txt_Parcode.Text = product.Parcode;
                txt_price1.Text = product.Price_1.ToString();
                txt_price2.Text = product.Price_2.ToString();
                txt_price3.Text = product.Price_3.ToString();
                txt_qty.Text = product.Quantity.ToString();
            }

            lstbox.Visible = false;
        }

    }
}
