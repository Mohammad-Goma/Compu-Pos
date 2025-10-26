using Compu_Pos.Data.Models;

namespace Compu_Pos.Data.IRepos
{
    public interface IProduct_Repo
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<Product?> GetByBarcode(string barcode);
        Task Add(Product model);
        Task Update(int id, Product model);
        Task Delete(int id); 
        Task<List<Product>> Search(string keyword); 
        Task<List<Product>> SearchParcode(string keyword);
        Task<List<Product>> SearchName(string keyword);
        Task<List<Product>> SearchName();
    }
}
