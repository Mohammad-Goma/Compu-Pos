using Compu_Pos.Data.Context;
using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Compu_Pos.Data.Implement
{
    public class Company_Imp : ICompany_Repo
    {
        private readonly ApplicationDBContext _Context;
        public Company_Imp(ApplicationDBContext Context)
        {
            _Context = Context;
        }

        public async Task Add(Company model)
        {
            await _Context.Companies.AddAsync(model);
            await Save();
        }

        public async Task Delete(int id)
        {
            var prod = await _Context.Companies.FindAsync(id);
            if (prod != null)
            {
                _Context.Companies.Remove(prod);
                await Save();
            }
        }

        public async Task Update(Company model)
        {
            var comp = await _Context.Companies.FindAsync(model.Id);
            if (comp != null)
                comp.Name = model.Name;
                comp!.Address = model.Address;
                comp.PhoneNumber = model.PhoneNumber;
                comp.Email = model.Email;
            comp.EstablishedDate = model.EstablishedDate;
            _Context.Companies.Update(comp!);
            await Save();
        }

        public async Task<IEnumerable<Company>> GetAll()
        {
            var prod = await _Context.Companies.ToListAsync();
            return prod!;
        }

        public async Task<Company> GetById(int id)
        {
            var prod = await _Context.Companies.FindAsync(id);
            return prod!;
        }


        private async Task Save()
        {
            await _Context.SaveChangesAsync();
        }
    }
}
