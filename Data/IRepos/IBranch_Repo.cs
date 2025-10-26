using Compu_Pos.Data.Models;

namespace Compu_Pos.Data.IRepos
{
    public interface IBranch_Repo
    {
        Task<IEnumerable<Branch>> GetAll();
        Task<Branch> GetById(int id);
        Task Add(Branch model);
        Task Update(Branch model);
        //Task Update(int id,Branch model);
        Task Delete(int id);
    }
}
