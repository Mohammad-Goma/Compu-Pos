using Compu_Pos.Data.Models;

namespace Compu_Pos.Data.IRepos
{
    public interface ICustomer_Repo
    {
        Task<IEnumerable<Customer>> GetAll();
        Task<Customer> GetById(int id);
        Task Add(Customer model);
        Task Update(Customer model);
        Task Delete(int id);
    }
}
