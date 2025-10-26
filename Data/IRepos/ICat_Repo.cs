using Compu_Pos.Data.Models;

namespace Compu_Pos.Data.IRepos
{
    public interface ICat_Repo
    {
         Task<IEnumerable<Cat>> GetAll();
         Task<Cat> GetById(int id);
         Task Add(Cat model);
         Task Update(Cat model);
         Task Delete(int id);
    }
}
