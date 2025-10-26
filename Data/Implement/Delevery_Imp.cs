using Compu_Pos.Data.Context;
using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Compu_Pos.Data.Implement
{
    public class Delevery_Imp : IDelevery_Repo
    {
        private readonly ApplicationDBContext _Context;
        public Delevery_Imp(ApplicationDBContext Context)
        {
            _Context = Context;
        }

        public async Task Add(Delevery model)
        {
            await _Context.Deleveries.AddAsync(model);
            await Save();
        }

        public async Task Delete(int id)
        {
            var prod = await _Context.Deleveries.FindAsync(id);
            if (prod != null)
            {
                _Context.Deleveries.Remove(prod);
                await Save();
            }
        }

        public Task<IEnumerable<Delevery>> GetComp_Delev()
        {
            throw new NotImplementedException();
        }

        public async Task Update(Delevery model)
        {
            var prod = await _Context.Deleveries.FindAsync(model.Id);
            _Context.ChangeTracker.Clear();
            _Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _Context.Entry(model).State = EntityState.Modified;
            await _Context.SaveChangesAsync();
        }

        async Task<IEnumerable<Delevery>> IDelevery_Repo.GetAll()
        {
            var result = await _Context.Deleveries
                .Include(d => d.Company)
                .ToListAsync();
            return result;
        }

        async Task<Delevery> IDelevery_Repo.GetById(int id)
        {
            var prod = await _Context.Deleveries.FindAsync(id);
            return prod!;
        }


        private async Task Save()
        {
            await _Context.SaveChangesAsync();
        }
    }
}
