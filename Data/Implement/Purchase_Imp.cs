using Compu_Pos.Data.Context;
using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Compu_Pos.Data.Implement
{
    public class Purchase_Imp : IPurchase_Repo
    {
        private readonly ApplicationDBContext _context;
        public Purchase_Imp(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task Add(Purchase model)
        {
            await _context.Purchases.AddAsync(model);
            Save();
        }

        public async Task Delete(int id)
        {
            try
            {
                var purchase = await _context.Purchases
                    .Include(p => p.Items)
                    .FirstOrDefaultAsync(p => p.Id == id);

                if (purchase != null)
                {
                    _context.Purchases.Remove(purchase);
                    Save();
                }
            }
            catch
            {

            }
        }

        public async Task<IEnumerable<Purchase>> GetAll()
        {
            return await _context.Purchases
                .Include(p => p.Delevery)
                .Include(p => p.Items)
                .ToListAsync();
        }

        public async Task<Purchase?> GetById(int id)
        {
            return await _context.Purchases
                .Include(p => p.Delevery)
                .Include(p => p.Items)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<Product?> GetByBarcode(string barcode)
        {
            return await _context.Products
                .FirstOrDefaultAsync(p => p.Parcode == barcode);
        }

        async Task<int> IPurchase_Repo.GetNextPurchaseNumber()
        {
            var maxId = await _context.Purchases.MaxAsync(i => i.Id);
            return maxId;
        }

        public async Task Update(Purchase model)
        {
            _context.Purchases.Update(model);
            await
            _context.SaveChangesAsync();
        }



        public async Task<List<Product>> SearchBarcode(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return new List<Product>();
            try
            {
                var keywordLower = keyword.ToLower();

                var results = await _context.Products
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

                var results = await _context.Products
                    .Where(item => item.Name != null && item.Name.ToLower() == keywordLower)
                    .ToListAsync();

                return results;
            }
            catch (Exception)
            {
                return new List<Product>();
            }
        }
        private void Save()
        {
            _context.SaveChangesAsync();
        }

    }
}
