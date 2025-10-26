using Compu_Pos.Data.Context;
using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Compu_Pos.Data.Implement
{
    public class Store_Imp : IStore_Repo
    {
        private readonly ApplicationDBContext _Context;
        public Store_Imp(ApplicationDBContext Context)
        {
            _Context = Context;
        }

        public async Task Add(Store model)
        {
            await _Context.Stores.AddAsync(model);
            await Save();
        }

        public async Task Delete(int id)
        {
            var prod = await _Context.Stores.FindAsync(id);
            if (prod != null)
            {
                _Context.Stores.Remove(prod);
                await Save();
            }
        }

        public async Task Update(Store model) //يحتاج تعديل 
        {
            var existingBranch = await _Context.Stores.FirstOrDefaultAsync(b => b.Id == model.Id);

            if (existingBranch is not null)
            {
                // تحديث القيم بشكل صريح
                existingBranch.Name = model.Name;
                existingBranch.Description = model.Description;
                await Save();
            }

            // var prod = await _Context.Stores.FindAsync(model.Id);
            // _Context.ChangeTracker.Clear();
            // _Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            // _Context.Entry(model).State = EntityState.Modified;
            // await _Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Store>> GetAll()
        {
            var prod = await _Context.Stores.ToListAsync();
            return prod!;
        }

        public async Task<Store> GetById(int id)
        {
            var prod = await _Context.Stores.FindAsync(id);
            return prod!;
        }

        private async Task Save()
        {
            await _Context.SaveChangesAsync();
        }
    }
}
