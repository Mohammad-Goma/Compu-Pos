using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;

namespace Compu_Pos.Views
{
    public partial class frm_Delevery : Form
    {
        private readonly IDelevery_Repo _delevery_Repo;
        private readonly ICompany_Repo _comp_Repo;
        public frm_Delevery(IDelevery_Repo delevery_Repo, ICompany_Repo comp_Repo)
        {
            InitializeComponent();
            _delevery_Repo = delevery_Repo;
            _comp_Repo = comp_Repo;
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

        private void ClearAll()
        {
            Id.Text = string.Empty;
            Name_D.Text = string.Empty;
            PhoneNumber.Text = string.Empty;
            PhoneNumber_2.Text = string.Empty;
            PhoneNumber_3.Text = string.Empty;
            DeliveryDate.Text = string.Empty;
            cbo_comp.SelectedItem = -1;
        }

        private void SaveAsync()
        {
            var com = new Delevery
            {
                Name = Name_D.Text.Trim(),
                PhoneNumber = PhoneNumber.Text.Trim(),
                PhoneNumber_2 = PhoneNumber_2.Text.Trim(),
                PhoneNumber_3 = PhoneNumber_3.Text.Trim(),
                DeliveryDate = DeliveryDate.Value,
                CompanyId = Convert.ToInt32(cbo_comp.SelectedItem)
            };
            _delevery_Repo.Add(com);
            MessageBox.Show("🎉 تم الحفظ بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateAsync()
        {
            var com = new Delevery
            {
                Id = Convert.ToInt32(Id.Text.Trim()),
                Name = Name_D.Text.Trim(),
                PhoneNumber = PhoneNumber.Text.Trim(),
                PhoneNumber_2 = PhoneNumber_2.Text.Trim(),
                PhoneNumber_3 = PhoneNumber_3.Text.Trim(),
                DeliveryDate = DeliveryDate.Value,
                //CompanyId = Convert.ToInt32(cbo_comp.SelectedItem)
            };
            _delevery_Repo.Update(com);
            MessageBox.Show("🎉 تم التعديل بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Id.Text.Trim());
                _delevery_Repo.Delete(id);
                MessageBox.Show("تم الحذف بنجاح.");      // “Deleted successfully.”
                ClearAll();
                LoadLstBox();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task LoadLstBox()
        {
            try
            {
                if (lst_box.Items.Count > 0)
                    lst_box.Items.Clear();
                var results = await _delevery_Repo.GetAll();
                foreach (var item in results)
                {
                    lst_box.Items.Add($"{item.Id} - {item.Name} - {item.Company?.Name} ");
                }
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

        //private void lst_box_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    if (lst_box.SelectedItem != null)
        //    {
        //        string selectedText = lst_box.SelectedItem.ToString()!;
        //        string selectedId = selectedText.Split('-')[0].Trim();
        //        string selectedName = selectedText.Split('-')[1].Trim();
        //        string selectedComp = selectedText.Split('-')[2].Trim();

        //        Id.Text = selectedId!;
        //        Name_D.Text = selectedName;
        //        cbo_comp.Text = selectedComp!;

        //        var findstrings = _delevery_Repo.GetById(Convert.ToInt32(selectedId));
        //        PhoneNumber.Text = findstrings.Result.PhoneNumber;
        //        PhoneNumber_2.Text = findstrings.Result.PhoneNumber_2;
        //        PhoneNumber_3.Text = findstrings.Result.PhoneNumber_3;
        //        DeliveryDate.Value = findstrings.Result.DeliveryDate;

        //    }
        //    else { return; }
        //}

        private async void frm_Delevery_Load(object sender, EventArgs e)
        {
            //LoadLstBox();
            await LoadDeleveryAndCompany();
        }

        private async Task LoadDeleveryAndCompany()
        {
            // تحميل الشركات
            List<Company> comp = (await _comp_Repo.GetAll()).ToList();
            cbo_comp.DataSource = comp;
            cbo_comp.DisplayMember = "Name";
            cbo_comp.ValueMember = "Id";
            cbo_comp.SelectedIndex = -1;

            // تحميل المناديب
            List<Delevery> delv = (await _delevery_Repo.GetAll()).ToList();

            cbo_delevery.DataSource = delv;
            cbo_delevery.DisplayMember = "Name";
            cbo_delevery.ValueMember = "Id";
            cbo_delevery.SelectedIndex = -1;
        }

        private void cbo_delevery_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbo_delevery.SelectedItem is Delevery selectedDelv)
            {
                Id.Text = selectedDelv.Id.ToString();
                Name_D.Text = selectedDelv.Name;
                PhoneNumber.Text = selectedDelv.PhoneNumber;
                PhoneNumber_2.Text = selectedDelv.PhoneNumber_2;
                PhoneNumber_3.Text = selectedDelv.PhoneNumber_3;
                DeliveryDate.Value = selectedDelv.DeliveryDate;
                cbo_comp.Text = selectedDelv.Company?.Name;
            }
            else
            {
                ClearDeleveryFields();
            }
        }


        private void ClearDeleveryFields()
        {
            Id.Text = string.Empty;
            Name_D.Text = string.Empty;
            PhoneNumber.Text = string.Empty;
            PhoneNumber_2.Text = string.Empty;
            PhoneNumber_3.Text = string.Empty;

            // تأكد إن ComboBox يرجع لحالة غير محددة
            cbo_delevery.Text = string.Empty; 
        }
    }
}
