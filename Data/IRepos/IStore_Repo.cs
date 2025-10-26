using Compu_Pos.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Pos.Data.IRepos
{
    public interface IStore_Repo
    {
        Task<IEnumerable<Store>> GetAll();
        Task<Store> GetById(int id);
        Task Add(Store model);
        Task Update(Store model);
        Task Delete(int id);
    }
}
