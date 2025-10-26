using Compu_Pos.Data.Models;

namespace Compu_Pos.Data.IRepos
{
    public interface IUnit_Repo
    {
        Task<IEnumerable<Unit>> GetAll();
        Task<Unit> GetById(int id);
        Task Add(Unit model);
        Task Update(Unit model);
        Task Delete(int id);
    }
}
