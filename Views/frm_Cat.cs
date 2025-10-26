using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;

namespace Compu_Pos.Views
{
    public partial class frm_Cat : Form
    {
        private readonly ICat_Repo _repo;
        private readonly IStore_Repo _store_Repo;
        private readonly IBranch_Repo _branch_Repo;
        public frm_Cat(ICat_Repo repo, IStore_Repo store_Repo, IBranch_Repo branch_Repo)
        {
            InitializeComponent();
            _repo = repo;
            _store_Repo = store_Repo;
            _branch_Repo = branch_Repo;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_id.Text))
            {
                Save();
                //Thread.Sleep(1000);
                Clear();
            }
            else
            {
                Update();
                //Thread.Sleep(1000);
                Clear();
            }
        }

        private async Task Save()
        {
            if (_repo == null)
            {
                MessageBox.Show("خدمة المنتج غير مهيأة بشكل صحيح.", "خطأ في التهيئة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var cat = new Cat
                {
                    Name = txt_name.Text,
                    BranchId = cbo_branch.ValueMember.Length,
                    StoreId = cbo_store.ValueMember.Length
                };
                await _repo.Add(cat);
                MessageBox.Show("🎉 تم الحفظ بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($" حدث خطأ أثناء عملية الحفظ:\n{ex.Message}", "خطأ غير متوقع", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lst_Load();
            }
        }

        private async Task Update()
        {
            try
            {
                var cat = new Cat
                {
                    Id = Convert.ToInt32(txt_id.Text),
                    Name = txt_name.Text,
                    BranchId = cbo_branch.ValueMember.Length,
                    StoreId = cbo_store.ValueMember.Length
                };
                await _repo!.Update(cat);
                MessageBox.Show("تم التعديل بنجاح .");
            }
            catch { throw; }
            finally
            {
                lst_Load();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_id.Text, out int id))
            {
                Delete(id);
                Clear();
            }
            else
            {
                MessageBox.Show("يرجى إدخال معرف صالح.");
            }
        }

        private async Task Delete(int id)
        {
            await _repo!.Delete(id);
            MessageBox.Show("تم الحذف بنجاح.");  // “Deleted successfully.”

            Clear();
            lst_Load();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Clear();
            lst_Load();
        }

        private void Clear()
        {

            txt_id.Text = "";
            txt_name.Text = "";
            cbo_branch.SelectedItem = null;
            cbo_store.SelectedItem = null;
        }

        private void frm_Cat_Load(object sender, EventArgs e)
        {
            lst_Load();

            Thread.Sleep(300);
            FillCbo_STore();

            Thread.Sleep(300);
            FillCbo_Branch();
        }


        private async Task FillCbo_STore()
        {
            List<Store> store = (await _store_Repo.GetAll()).ToList();
            cbo_store.DataSource = store;
            cbo_store.ValueMember = "Id";
            cbo_store.DisplayMember = "Name";
            if (store?.Any() == true)
            {
                cbo_store.SelectedIndex = -1;
            }
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

        private async Task lst_Load()
        {
            try
            {
                var results = await _repo.GetAll();
                lst_box.Items.Clear();
                foreach (var item in results)
                {
                    lst_box.Items.Add($"{item.Id} - {item.Name}");
                    //lst_box.Items.Add($"{item.Id} - {item.Name} - {item.BranchId} - {item.StoreId}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void lst_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_box.SelectedItem != null)
            {
                string selectedText = lst_box.SelectedItem.ToString()!;

                string selectedParcode = selectedText.Split('-')[0].Trim();
                string selectedName = selectedText.Split('-')[1].Trim();
                //string selectedBranch = selectedText.Split('-')[2].Trim();
                //string selectedStore = selectedText.Split('-')[3].Trim();

                txt_id.Text = selectedParcode;
                txt_name.Text = selectedName;
                //cbo_branch.Text = selectedBranch;
                //cbo_store.Text = selectedStore;
            }
            else { return; }
        }
    }
}
