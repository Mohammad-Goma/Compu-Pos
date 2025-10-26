using Compu_Pos.Data.Context;
using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Compu_Pos.Data.Implement
{
    public class Branch_Imp : IBranch_Repo
    {
        private readonly ApplicationDBContext _Context;
        public Branch_Imp(ApplicationDBContext Context)
        {
            _Context = Context;
        }

        public async Task Add(Branch model)
        {
            await _Context.Branches.AddAsync(model);
            await Save();
        }

        public async Task Delete(int id)
        {
            var prod = await _Context.Branches.FindAsync(id);
            if (prod != null)
            {
                _Context.Branches.Remove(prod);
                await Save();
            }
        }

        public async Task Update(Branch model)
        {
            var existingBranch = await _Context.Branches.FirstOrDefaultAsync(b => b.Id == model.Id);

            if (existingBranch is not null)
            {
                // تحديث القيم بشكل صريح
                existingBranch.Name = model.Name;
                existingBranch.Description = model.Description;

                await Save();
            }
        }

        public async Task<IEnumerable<Branch>> GetAll()
        {
                return await _Context.Branches.AsNoTracking().ToListAsync()
                ?? Enumerable.Empty<Branch>(); // تعويض في حال رجعت null (رغم أنها نادرة)
        }

        async Task<Branch> IBranch_Repo.GetById(int id)
        {
            var prod = await _Context.Branches.FindAsync(id);
            return prod!;
        }

        private async Task Save()
        {
            await _Context.SaveChangesAsync();
        }
    }
}
