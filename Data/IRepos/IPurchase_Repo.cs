using Compu_Pos.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Pos.Data.IRepos
{
    public interface IPurchase_Repo
    {
        Task<IEnumerable<Purchase>> GetAll();
        Task<Purchase> GetById(int id);
        Task Add(Purchase model);
        Task Update(Purchase model);
        Task Delete(int id);
        Task<int> GetNextPurchaseNumber();
        Task<List<Product>> SearchBarcode(string keyword);
        Task<List<Product>> SearchName(string keyword);
    }
}
