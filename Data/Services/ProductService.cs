using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;
using Compu_Pos.Data.ViewModel.Compu_Pos.Data.ViewModel;

namespace Compu_Pos.Data.Services
{
    public class ProductService
    {
        private readonly IProduct_Repo _productRepo;
        private readonly IUnit_Repo _unitRepo;
        private readonly ICat_Repo _categoryRepo;
        private readonly IStore_Repo _storeRepo;
        private readonly IBranch_Repo _branchRepo;

        public ProductService(
            IProduct_Repo productRepo,
            IUnit_Repo unitRepo,
            ICat_Repo categoryRepo,
            IStore_Repo storeRepo,
            IBranch_Repo branchRepo)
        {
            _productRepo = productRepo;
            _unitRepo = unitRepo;
            _categoryRepo = categoryRepo;
            _storeRepo = storeRepo;
            _branchRepo = branchRepo;
        }

        private async Task<ProductDetailsDto> GetProductDetails(Product product)
        {
            var unitTask = _unitRepo.GetById(product.UnitId);
            var categoryTask = _categoryRepo.GetById(product.CatId);
            var storeTask = _storeRepo.GetById(product.StoreId);
            var branchTask = _branchRepo.GetById(product.BranchId);

            await Task.WhenAll(unitTask, categoryTask, storeTask, branchTask);

            return new ProductDetailsDto
            {
                ProductName = product.Name ?? "غير معروف",
                Parcode = product.Parcode ?? "غير متوفر",
                Price_1 = Math.Round(product.Price_1, 2),
                Price_2 = Math.Round(product.Price_2, 2),
                Price_3 = Math.Round(product.Price_3, 2),
                UnitName = unitTask.Result?.Name ?? "غير محدد",
                CategoryName = categoryTask.Result?.Name ?? "غير مصنّف",
                StoreName = storeTask.Result?.Name ?? "غير معروف",
                BranchName = branchTask.Result?.Name ?? "غير محدد"
            };
        }

        public async Task<ProductDetailsDto?> GetProductDetailsByBarcode(string barcode)
        {
            if (string.IsNullOrWhiteSpace(barcode))
                return null;

            var product = await _productRepo.GetByBarcode(barcode.Trim());
            if (product == null)
                return null;

            //var unitTask = _unitRepo.GetById(product.UnitId);
            //var categoryTask = _categoryRepo.GetById(product.CatId);
            //var storeTask = _storeRepo.GetById(product.StoreId);
            //var branchTask = _branchRepo.GetById(product.BranchId);

            //await Task.WhenAll(unitTask, categoryTask, storeTask, branchTask);

            //var unit = unitTask.Result;
            //var category = categoryTask.Result;
            //var store = storeTask.Result;
            //var branch = branchTask.Result;

            return new ProductDetailsDto
            {
                ProductName = product.Name ?? "غير معروف",
                Parcode = product.Parcode ?? "غير متوفر",
                Price_1 = Math.Round(product.Price_1, 2),
                Price_2 = Math.Round(product.Price_2, 2),
                Price_3 = Math.Round(product.Price_3, 2),
                //UnitName = unit?.Name ?? "غير محدد",
                //CategoryName = category?.Name ?? "غير مصنّف",
                //StoreName = store?.Name ?? "غير معروف",
                //BranchName = branch?.Name ?? "غير محدد"
            };
        }

        public async Task<ProductDetailsDto?> GetProductDetailsByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            var products = await _productRepo.SearchName(name.Trim());
            var product = products.FirstOrDefault(); // يمكنك تعديل هذا حسب منطقك في اختيار المنتج

            if (product == null)
                return null;

            var unitTask = _unitRepo.GetById(product.UnitId);
            var categoryTask = _categoryRepo.GetById(product.CatId);
            var storeTask = _storeRepo.GetById(product.StoreId);
            var branchTask = _branchRepo.GetById(product.BranchId);

            await Task.WhenAll(unitTask, categoryTask, storeTask, branchTask);

            var unit = unitTask.Result;
            var category = categoryTask.Result;
            var store = storeTask.Result;
            var branch = branchTask.Result;

            return new ProductDetailsDto
            {
                ProductName = product.Name ?? "غير معروف",
                Parcode = product.Parcode ?? "غير متوفر",
                Price_1 = Math.Round(product.Price_1, 2),
                Price_2 = Math.Round(product.Price_2, 2),
                Price_3 = Math.Round(product.Price_3, 2),
                UnitName = unit?.Name ?? "غير محدد",
                CategoryName = category?.Name ?? "غير مصنّف",
                StoreName = store?.Name ?? "غير معروف",
                BranchName = branch?.Name ?? "غير محدد"
            };
        }
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var Prods = await _productRepo.GetAll();
            return Prods.AsEnumerable(); // ✅ تحويل صريح
        }

        public async Task<IEnumerable<Unit>> GetUnitsAsync()
        {
            var units = await _unitRepo.GetAll();
            return units.AsEnumerable(); // ✅ تحويل صريح
        }

        public async Task<IEnumerable<Cat>> GetCategoriesAsync()
        {
            return await _categoryRepo.GetAll();
        }

        public async Task<IEnumerable<Store>> GetStoresAsync()
        {
            return await _storeRepo.GetAll();
        }

        public async Task<IEnumerable<Branch>> GetBranchesAsync()
        {
            return await _branchRepo.GetAll();
        }
    }
}
