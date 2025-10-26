using Compu_Pos.Data.Models;

namespace Compu_Pos.Data.IRepos
{
    public interface Iinvoice_Repo
    {
        Task<IEnumerable<Invoice>> GetAll();
        Task<Invoice> GetById(int id);
        Task Add(Invoice model);
        Task Update(Invoice model);
        Task Delete(int id);
        Task<int> GetNextInvoiceNumber();
    }
}
