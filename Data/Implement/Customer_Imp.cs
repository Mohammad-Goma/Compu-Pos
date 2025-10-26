using Compu_Pos.Data.Context;
using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Compu_Pos.Data.Implement
{
    public class Customer_Imp : ICustomer_Repo
    {
        private readonly ApplicationDBContext _Context;
        public Customer_Imp(ApplicationDBContext Context)
        {
            _Context = Context;
        }
        async Task ICustomer_Repo.Add(Customer model)
        {
            await _Context.Customers.AddAsync(model);
            await Save();
        }

        async Task ICustomer_Repo.Delete(int id)
        {
            var prod = await _Context.Customers.FindAsync(id);
            if (prod != null)
            {
                _Context.Customers.Remove(prod);
                await Save();
            }
        }

        async Task<IEnumerable<Customer>> ICustomer_Repo.GetAll()
        {
            var prod = await _Context.Customers.ToListAsync();
            return prod!;
        }

        async Task<Customer> ICustomer_Repo.GetById(int id)
        {
            var prod = await _Context.Customers.FindAsync(id);
            return prod!;
        }

        async Task ICustomer_Repo.Update(Customer model)
        {
            var prod = await _Context.Customers.FindAsync(model.Id);
            _Context.ChangeTracker.Clear();
            _Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _Context.Entry(model).State = EntityState.Modified;
            await _Context.SaveChangesAsync();
        }
        private async Task Save()
        {
            await _Context.SaveChangesAsync();
        }
    }
}
