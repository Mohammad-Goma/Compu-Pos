using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;

namespace Compu_Pos.Views
{
    public partial class frm_Store : Form
    {
        private readonly IStore_Repo _store;
        private readonly IBranch_Repo _branch_Repo;
        public frm_Store(IStore_Repo store, IBranch_Repo branch_Repo)
        {
            InitializeComponent();
            _store = store;
            _branch_Repo = branch_Repo;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_id.Text))
            {
                AddAsync();
                //ClearAll();
            }
            else
            {
                int id = Convert.ToInt32(txt_id.Text.Trim());
                UpdateAsync();
                //ClearAll();
            }
        }

        public async Task AddAsync()
        {
            if (_store == null)
            {
                MessageBox.Show("خدمة المنتج غير مهيأة بشكل صحيح.", "خطأ في التهيئة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var store = new Store
                {
                    Name = txt_name.Text,
                    BranchId = Convert.ToInt32(cbo_branch.SelectedValue),
                    Description = txt_details.Text.Trim()
                };
                await _store.Add(store);
                MessageBox.Show("🎉 تم الحفظ بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء عملية الحفظ:\n{ex.Message}", "خطأ غير متوقع", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task UpdateAsync()
        {
            try
            {
                var newstore = new Store
                {
                    Id = Convert.ToInt32(txt_id.Text.Trim()),
                    Name = txt_name.Text,
                    BranchId = Convert.ToInt32(cbo_branch.SelectedValue),
                    Description = txt_details.Text.Trim()
                };
                await _store!.Update(newstore);
                MessageBox.Show("تم التعديل بنجاح .");
            }
            catch { }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_id.Text, out int id))
            {
                Delete(id);
                //ClearAll();
            }
            else
            {
                MessageBox.Show("يرجى إدخال معرف صالح.");
            }
        }

        private async Task Delete(int id)
        {
            await _store!.Delete(id);
            MessageBox.Show("تم الحذف بنجاح.");  // “Deleted successfully.”
        }

        private async void ClearAll()
        {
            cbo_branch.DataSource = null;        // فك الربط أولًا
            cbo_Store.DataSource = null;         // فك الربط أولًا
            txt_id.Text = "";
            txt_name.Text = "";
            txt_details.Text = "";
            //await FillCbo_Branch();
            await LoadToCBO_Store();        // تأكد أن LoadToCBO غير متزامنة وتُنتظر بشكل صحيح
        }

        private async Task LoadToCBO_Store()
        {
            List<Store> stores = (await _store.GetAll()).ToList();

            cbo_Store.DataSource = stores;
            cbo_Store.DisplayMember = "Name";
            cbo_Store.ValueMember = "Id";
            cbo_Store.SelectedIndex = -1;
        }

        private async Task FillCbo_Branch()
        {
            List<Branch> branches = (await _branch_Repo.GetAll()).ToList();
            cbo_branch.DataSource = branches;
            cbo_branch.ValueMember = "Id";
            cbo_branch.DisplayMember = "Name";
            if (branches?.Any() == true)
            {
                cbo_branch.SelectedIndex = -1;
            }
        }

        private void cbo_Store_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Store.SelectedItem is Store selectedStore && selectedStore.Id != 0)
            {
                txt_id.Text = selectedStore.Id.ToString();
                txt_name.Text = selectedStore.Name;
                txt_details.Text = selectedStore.Description;
                cbo_branch.SelectedValue = selectedStore.BranchId;
            }
            else
            {
                txt_id.Text = "";
                txt_name.Text = "";
                txt_details.Text = "";
                cbo_branch.Text = "";
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void frm_Store_Load(object sender, EventArgs e)
        {
            LoadToCBO_Store();
            Thread.Sleep(1000);
            FillCbo_Branch();
        }
    }
}
