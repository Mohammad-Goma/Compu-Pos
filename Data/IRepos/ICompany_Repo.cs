using Compu_Pos.Data.Models;

namespace Compu_Pos.Data.IRepos
{
    public interface ICompany_Repo
    {
        Task<IEnumerable<Company>> GetAll();
        Task<Company> GetById(int id);
        Task Add(Company model);
        Task Update(Company model);
        Task Delete(int id);
    }
}
