using Compu_Pos.Data.Context;
using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Compu_Pos.Data.Implement
{

    public class Cat_Imp : ICat_Repo
    {
        private readonly ApplicationDBContext _Context;
        public Cat_Imp(ApplicationDBContext Context)
        {
            _Context = Context;
        }

        public async Task Add(Cat model)
        {
            await _Context.Cats.AddAsync(model);
            await Save();
        }

        public async Task Delete(int id)
        {
            var prod = await _Context.Cats.FindAsync(id);
            if (prod != null)
            {
                _Context.Cats.Remove(prod);
                await Save();
            }
        }

        public async Task Update(Cat model)
        {
            try
            {

                var cat = await _Context.Cats.FindAsync(model.Id);
                if (cat != null)
                    cat.Name = model.Name;
                _Context.Cats.Update(cat!);
                await Save();
            }
            catch (Exception)
            {

                throw;
            }
        }

        async Task<IEnumerable<Cat>> ICat_Repo.GetAll()
        {
            try
            {

                var prod = await _Context.Cats.ToListAsync();
                return prod!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        async Task<Cat> ICat_Repo.GetById(int id)
        {
            try
            {

                var prod = await _Context.Cats.FindAsync(id);
                return prod!;
            }
            catch (Exception)
            {

                throw;
            }
        }


        private async Task Save()
        {
            await _Context.SaveChangesAsync();
        }

    }
}
