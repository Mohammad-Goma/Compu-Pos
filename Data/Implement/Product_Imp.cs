using Compu_Pos.Data.Context;
using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Compu_Pos.Data.Implement
{
    public class Product_Imp : IProduct_Repo
    {
        private readonly ApplicationDBContext _Context;
        public Product_Imp(ApplicationDBContext Context)
        {
            _Context = Context;
        }

        public async Task Add(Product model)
        {
            await _Context.Products.AddAsync(model);
            Save();
        }

        public async Task Delete(int id)
        {
            var prod = await _Context.Products.FindAsync(id);
            if (prod != null)
            {
                _Context.Products.Remove(prod);
                Save();
            }
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var prod = await _Context.Products.ToListAsync();
            return prod;
        }

        public async Task<Product> GetById(int id)
        {
            var prod = await _Context.Products.FindAsync(id);
            return prod!;
        }

        public async Task Update(int Id, Product model)
        {
            var prod = await _Context.Products.FindAsync(Id);
            _Context.ChangeTracker.Clear();
            _Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _Context.Entry(model).State = EntityState.Modified;
            Save();
        }

        private void Save()
        {
            _Context.SaveChangesAsync();
        }

        public async Task<List<Product>> Search(string keyword)  // باركود واسم
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return new List<Product>();

            try
            {
                var keywordLower = keyword.ToLower();

                var results = await _Context.Products
                    .Where(item =>
                        (item.Parcode != null && item.Parcode.ToLower().Contains(keywordLower)) ||
                        (item.Name != null && item.Name.ToLower().Contains(keywordLower)))
                    .ToListAsync();

                return results;
            }
            catch (Exception)
            {
                return new List<Product>();
            }
        }
        public async Task<Product?> GetByBarcode(string barcode)
        {
            if (string.IsNullOrWhiteSpace(barcode))
                return null;

            return await _Context.Products
                .FirstOrDefaultAsync(p => p.Parcode != null && p.Parcode.ToLower() == barcode.Trim().ToLower());
        }

        public async Task<List<Product>> SearchParcode(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return new List<Product>();
            try
            {
                var keywordLower = keyword.ToLower();

                var results = await _Context.Products
                    .Where(item => item.Parcode != null && item.Parcode.ToLower() == keywordLower)
                    .ToListAsync();

                return results;
            }
            catch (Exception)
            {
                return new List<Product>();
            }
        }

        public async Task<List<Product>> SearchName(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return new List<Product>();
            try
            {
                var keywordLower = keyword.ToLower();

                var results = await _Context.Products
                    .Where(item => item.Name != null && item.Name.ToLower() == keywordLower)
                    .ToListAsync();

                return results;
            }
            catch (Exception)
            {
                return new List<Product>();
            }
        }

        public async Task<List<Product>> SearchName()
        {
            try
            {
                var results = await _Context.Products.ToListAsync();
                return results;
            }
            catch (Exception)
            {
                return new List<Product>();
            }
        }

    }
}
