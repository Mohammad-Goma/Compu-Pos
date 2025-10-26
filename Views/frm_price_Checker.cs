using Compu_Pos.Data.IRepos;

namespace Compu_Pos.Views
{
    public partial class frm_price_Checker : Form
    {
        private readonly IProduct_Repo _productRepo;
        public frm_price_Checker(IProduct_Repo productRepo)
        {
            InitializeComponent();
            _productRepo = productRepo;
        }

        private async void Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string input = Search.Text.Trim();
                if (string.IsNullOrWhiteSpace(input)) return;

                var keyword = input.Split('-')[0].Trim(); // البحث بالباركود أو جزء منه
                var result = (await _productRepo.Search(keyword)).FirstOrDefault();

                if (result != null)
                {
                    name.Text = result.Name;
                    parcode.Text = result.Parcode;
                    price_2.Text = result.Price_2.ToString();
                    price_3.Text = result.Price_3.ToString();
                    qty.Text = result.Quantity.ToString();
                    qty.Text = result.Quantity.ToString();
                }

            }
            catch (Exception)
            {

            }

        }

        private void Search_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Thread.Sleep(1000);
            //Search.SelectAll();
        }
    }
}
