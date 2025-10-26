using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;

namespace Compu_Pos.Views
{
    public partial class frm_Employee : Form
    {
        private readonly IEmployee_Repo _emp_repo;
        public frm_Employee(IEmployee_Repo _Repo)
        {
            InitializeComponent();
            _emp_repo = _Repo;
        }

        private void frm_Employee_Load(object sender, EventArgs e)
        {
            LoadLstBox();
        }

        private async Task LoadLstBox()
        {
            try
            {
                if (lst_box.Items.Count > 0)
                    lst_box.Items.Clear();
                var results = await _emp_repo.GetAll();
                foreach (var item in results)
                {
                    lst_box.Items.Add($"{item.Id} - {item.FullName} - {item.JobTitle}");
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
            LoadLstBox();
        }

        private void ClearAll()
        {
            Id.Text = string.Empty;
            FullName.Text = string.Empty;
            JobTitle.Text = string.Empty;
            Department.Text = string.Empty;
            Salary.Text = string.Empty;
            HireDate.Value = DateTime.Now;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Id.Text.Trim());
                _emp_repo.Delete(id);
                MessageBox.Show("تم الحذف بنجاح.");      // “Deleted successfully.”
                ClearAll();
                LoadLstBox();
            }
            catch (Exception)
            {
                throw;
            }
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
            var com = new Employee
            {
                FullName = FullName.Text.Trim(),
                JobTitle = JobTitle.Text.Trim(),
                Department = Department.Text.Trim(),
                Salary = Convert.ToDecimal(Salary.Text.Trim()),
                HireDate = HireDate.Value
            };
            _emp_repo.Add(com);
            MessageBox.Show("🎉 تم الحفظ بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateAsync()
        {
            var com = new Employee
            {
                Id = Convert.ToInt32(Id.Text.Trim()),
                FullName = FullName.Text.Trim(),
                JobTitle = JobTitle.Text.Trim(),
                Department = Department.Text.Trim(),
                Salary = Convert.ToDecimal(Salary.Text.Trim()),
                HireDate = HireDate.Value
            };
            _emp_repo.Update(com);
            MessageBox.Show("🎉 تم التعديل بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام، النقطة العشرية، وBackspace فقط
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)8)
            {
                e.Handled = true; // تجاهل المفتاح
            }

            // منع إدخال أكثر من نقطة عشرية
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

        }

        private void lst_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_box.SelectedItem != null)
            {
                string selectedText = lst_box.SelectedItem.ToString()!;
                string selectedId = selectedText.Split('-')[0].Trim();
                string selectedName = selectedText.Split('-')[1].Trim();

                Id.Text = selectedId!;
                FullName.Text = selectedName;

                var findstrings = _emp_repo.GetById(Convert.ToInt32(selectedId));
                JobTitle.Text = findstrings.Result.JobTitle;
                Department.Text = findstrings.Result.Department;
                Salary.Text = (findstrings.Result.Salary).ToString();
                HireDate.Value = findstrings.Result.HireDate;
            }
            else { return; }
        }

    }
}
