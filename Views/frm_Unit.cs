using Compu_Pos.Data.IRepos;

namespace Compu_Pos.Views
{
    public partial class frm_Unit : Form
    {
        private readonly IUnit_Repo _unit_Repo;
        public frm_Unit(IUnit_Repo unit_Repo)
        {
            InitializeComponent();
            _unit_Repo = unit_Repo;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text.Trim() == string.Empty || txt_id.Text.Trim() == null)
                {
                    SaveAsync(); 
                }
                else if (txt_id.Text.Trim() != null)
                {
                    UpdateAsync();
                }
            }
            catch (Exception) { throw; }
        }

        public async void SaveAsync()
        {
            try
            {
                var uni = new Data.Models.Unit
                {
                    Name = txt_name.Text.Trim(),
                    Symbol = txt_symbol.Text.Trim()
                };
                await _unit_Repo.Add(uni);
                MessageBox.Show("🎉 تم الحفظ بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }
            finally {  ClearTextBoxes(); }
        }

        public async void UpdateAsync()
        {
            try
            {
                var uni = new Data.Models.Unit
                {
                    Id = Convert.ToInt32(txt_id.Text.Trim()),
                    Name = txt_name.Text.Trim(),
                    Symbol = txt_symbol.Text.Trim()
                };
                await _unit_Repo.Update(uni);
                MessageBox.Show("🎉 تم التعديل بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }
            finally { ClearTextBoxes(); }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text.Trim());
            _unit_Repo.Delete(id);
            MessageBox.Show("تم الحذف بنجاح.");      // “Deleted successfully.”
            ClearTextBoxes();
            lst_Load();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_symbol.Clear();
            lst_Load();
        }

        private async void frm_Unit_Load(object sender, EventArgs e)
        {
            await lst_Load();
        }

        private async Task lst_Load()
        {
            try
            {
                var results = await _unit_Repo.GetAll();
                lstbox.Items.Clear();
                foreach (var item in results)
                {
                    lstbox.Items.Add($"{item.Id} - {item.Name}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void lstbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbox.SelectedItem != null)
            {
                string selectedText = lstbox.SelectedItem.ToString()!;

                string selectedParcode = selectedText.Split('-')[0].Trim();
                string selectedName = selectedText.Split('-')[1].Trim();

                txt_id.Text = selectedParcode;
                txt_name.Text = selectedName;

            }
            else { return; }
        }
    }
}