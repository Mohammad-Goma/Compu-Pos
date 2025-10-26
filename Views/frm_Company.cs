using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;

namespace Compu_Pos.Views
{
    public partial class frm_Company : Form
    {
        private readonly ICompany_Repo _company_Repo;
        public frm_Company(ICompany_Repo company_Repo)
        {
            InitializeComponent();
            _company_Repo = company_Repo;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Trim() == string.Empty)
            {
                Save();
                //ClearAll(); 
                LoadLstBox();
            }
            else
            {
                Update();
                //ClearAll(); 
                LoadLstBox();
            }
        }

        public void Save()
        {
            var com = new Company
            {
                Name = txt_name.Text.Trim(),
                Address = txt_adress.Text.Trim(),
                Email = txt_email.Text.Trim(),
                PhoneNumber = txt_phone.Text.Trim(),
                EstablishedDate = DateTime.Now
            };
            _company_Repo.Add(com);
            MessageBox.Show("🎉 تم الحفظ بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Update()
        {
            var com = new Company
            {
                Id = Convert.ToInt32(txt_id.Text.Trim()),
                Name = txt_name.Text.Trim(),
                Address = txt_adress.Text.Trim(),
                Email = txt_email.Text.Trim(),
                PhoneNumber = txt_phone.Text.Trim(),
                EstablishedDate = dt_Company.Value
            };
            _company_Repo.Update(com);
            MessageBox.Show("🎉 تم التعديل بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ClearAll(); LoadLstBox();
        }

        private void ClearAll()
        {
            lst_box.Items.Clear();
            txt_id.Text = string.Empty;
            txt_name.Text = string.Empty;
            txt_phone.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_adress.Text = string.Empty;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_id.Text.Trim());
                _company_Repo.Delete(id);
                MessageBox.Show("تم الحذف بنجاح.");      // “Deleted successfully.”
                ClearAll();
                LoadLstBox();
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
                string selectedId = selectedText.Split('-')[0].Trim();
                string selectedName = selectedText.Split('-')[1].Trim();

                txt_id.Text = selectedId!;
                txt_name.Text = selectedName;
                var findstrings = _company_Repo.GetById(Convert.ToInt32(selectedId));
                txt_phone.Text = findstrings.Result.PhoneNumber;
                txt_email.Text = findstrings.Result.Email;
                txt_adress.Text = findstrings.Result.Address;
            }
            else { return; }
        }

        private async Task LoadLstBox()
        {
            try
            {
                if (lst_box.Items.Count > 0)
                    lst_box.Items.Clear();
                var results = await _company_Repo.GetAll();
                foreach (var item in results)
                {
                    lst_box.Items.Add($"{item.Id} - {item.Name} - {item.Address} - {item.PhoneNumber}- {item.Email}- {item.EstablishedDate}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void frm_Company_Load(object sender, EventArgs e)
        {
            LoadLstBox();
        }
    }
}
