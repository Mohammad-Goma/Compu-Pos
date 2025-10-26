using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;

namespace Compu_Pos.Views
{
    public partial class frm_Branch : Form
    {
        private readonly IBranch_Repo _branch_Repo;
        public frm_Branch(IBranch_Repo branch_Repo)
        {
            InitializeComponent();
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
            if (_branch_Repo == null)
            {
                MessageBox.Show("خدمة المنتج غير مهيأة بشكل صحيح.", "خطأ في التهيئة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var branch = new Branch
                {
                    Name = txt_name.Text,
                    Description = txt_details.Text.Trim()
                };
                await _branch_Repo.Add(branch);
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
                var newbranch = new Branch
                {
                    Id = Convert.ToInt32(txt_id.Text.Trim()),
                    Name = txt_name.Text,
                    Description = txt_details.Text.Trim()
                };
                await _branch_Repo!.Update(newbranch);
                MessageBox.Show("تم التعديل بنجاح .");
            }
            catch { }
        }

        private void frm_Branch_Load(object sender, EventArgs e)
        {
            LoadToCBO();
        }

        private async Task LoadToCBO()
        {
            List<Branch> branches = (await _branch_Repo.GetAll()).ToList();

            cbo_branch.DataSource = branches;
            cbo_branch.DisplayMember = "Name";
            cbo_branch.ValueMember = "Id";
            cbo_branch.SelectedIndex = -1;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_id.Text, out int id))
            {
                Delete(id);
                ClearAll();
            }
            else
            {
                MessageBox.Show("يرجى إدخال معرف صالح.");
            }
        }

        private async void Delete(int id)
        {
            await _branch_Repo!.Delete(id);
            MessageBox.Show("تم الحذف بنجاح."); // “Deleted successfully.”
        }

        private void cbo_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_branch.SelectedItem is Branch selectedBranch && selectedBranch.Id != 0)
            {
                txt_id.Text = selectedBranch.Id.ToString();
                txt_name.Text = selectedBranch.Name;
                txt_details.Text = selectedBranch.Description;
            }
            else
            {
                txt_id.Text = "";
                txt_name.Text = "";
                txt_details.Text = "";
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private async void ClearAll()
        {
            cbo_branch.DataSource = null;   // فك الربط أولًا
            txt_id.Text = "";
            txt_name.Text = "";
            txt_details.Text = "";
            await LoadToCBO();              // تأكد أن LoadToCBO غير متزامنة وتُنتظر بشكل صحيح
        }

    }
}
