using Compu_Pos.Data.Context;
using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Compu_Pos.Data.Implement
{
    public class Unit_Imp : IUnit_Repo
    {
        private readonly ApplicationDBContext _Context;
        public Unit_Imp(ApplicationDBContext Context)
        {
            _Context = Context;
        }

        public async Task Add(Unit model)
        {
            await _Context.Units.AddAsync(model);
            await Save();
        }

        public async Task Delete(int id)
        {
            var prod = await _Context.Units.FindAsync(id);
            if (prod != null)
            {
                _Context.Units.Remove(prod);
                await Save();
            }
        }

        public async Task Update(Unit model)
        {
            var unit = await _Context.Units.FindAsync(model.Id);
            if (unit != null)
                unit.Name = model.Name;
            _Context.Units.Update(unit!);
            await Save();
        }

        public async Task<IEnumerable<Unit>> GetAll()
        {
            var prod = await _Context.Units.ToListAsync();
            return prod!;
        }

        public async Task<Unit> GetById(int id)
        {
            var prod = await _Context.Units.FindAsync(id);
            return prod!;
        }

        private async Task Save()
        {
            await _Context.SaveChangesAsync();
        }
    }
}
