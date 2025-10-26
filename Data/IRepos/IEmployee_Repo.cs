using Compu_Pos.Data.Models;
using System;

namespace Compu_Pos.Data.IRepos
{
    public interface IEmployee_Repo
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<IEnumerable<string>> GetEmployeeNamesAsync();
        Task<Employee> GetById(int id);
        Task Add(Employee model);
        Task Update(Employee model);
        Task Delete(int id);
    }
}
