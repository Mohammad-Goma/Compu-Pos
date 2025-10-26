using Compu_Pos.Data.Models;

namespace Compu_Pos.Data.IRepos
{
    public interface IDelevery_Repo
    {
        Task<IEnumerable<Delevery>> GetAll();
        Task<Delevery> GetById(int id);
        Task Add(Delevery model);
        Task Update(Delevery model);
        Task Delete(int id);
        Task<IEnumerable<Delevery>> GetComp_Delev();
    }
}
