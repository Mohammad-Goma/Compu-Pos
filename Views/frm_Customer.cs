using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;

namespace Compu_Pos.Views
{
    public partial class frm_Customer : Form
    {
        private readonly ICustomer_Repo _CustRepo;
        public frm_Customer(ICustomer_Repo CustRepo)
        {
            InitializeComponent();
            _CustRepo = CustRepo;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Id.Text.Trim() == string.Empty)
            {
                SaveAsync();
                ClearAll();
                LoadLstBox();
            }
            else
            {
                UpdateAsync();
                ClearAll();
                LoadLstBox();
            }
        }

        private void SaveAsync()
        {
            var com = new Customer
            {
                FullName = FullName.Text.Trim(),
                PhoneNumber = PhoneNumber.Text.Trim(),
                Email = Email.Text.Trim(),
                Address = Address.Text.Trim()
            };
            _CustRepo.Add(com);
            MessageBox.Show("🎉 تم الحفظ بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateAsync()
        {
            var com = new Customer
            {
                Id = Convert.ToInt32(Id.Text.Trim()),
                FullName = FullName.Text.Trim(),
                PhoneNumber = PhoneNumber.Text.Trim(),
                Email = Email.Text.Trim(),
                Address = Address.Text.Trim()
            };
            _CustRepo.Update(com);
            MessageBox.Show("🎉 تم التعديل بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Id.Text.Trim());
                _CustRepo.Delete(id);
                MessageBox.Show("تم الحذف بنجاح.");      // “Deleted successfully.”
                ClearAll();
                LoadLstBox();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private async Task LoadLstBox()
        {
            try
            {
                if (lst_box.Items.Count > 0)
                    lst_box.Items.Clear();
                var results = await _CustRepo.GetAll();
                foreach (var item in results)
                {
                    lst_box.Items.Add($"{item.Id} - {item.FullName} ");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void ClearAll()
        {
            Id.Text = string.Empty;
            FullName.Text = string.Empty;
            PhoneNumber.Text = string.Empty;
            Email.Text = string.Empty;
            Address.Text = string.Empty;
        }

        private void lst_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (lst_box.SelectedItem != null)
                {
                    string selectedText = lst_box.SelectedItem.ToString()!;
                    string selectedId = selectedText.Split('-')[0].Trim();
                    string selectedName = selectedText.Split('-')[1].Trim();

                    Id.Text = selectedId!;
                    FullName.Text = selectedName;

                    var findstrings = _CustRepo.GetById(Convert.ToInt32(selectedId));
                    PhoneNumber.Text = findstrings.Result.PhoneNumber;
                    Email.Text = findstrings.Result.Email;
                    Address.Text = findstrings.Result.Address;
                }
                else { return; }
            }
            catch
            {

            }
        }

        private void frm_Customer_Load(object sender, EventArgs e)
        {
            LoadLstBox();
        }
    }
}
