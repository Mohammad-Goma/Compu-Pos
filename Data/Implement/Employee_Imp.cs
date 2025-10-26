using Compu_Pos.Data.Context;
using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Compu_Pos.Data.Implement
{
    public class Employee_Imp : IEmployee_Repo
    {
        private readonly ApplicationDBContext _Context;
        public Employee_Imp(ApplicationDBContext Context)
        {
            _Context = Context;
        }

        public async Task Add(Employee model)
        {
            await _Context.Employees.AddAsync(model);
            await Save();
        }

        public async Task Delete(int id)
        {
            var prod = await _Context.Employees.FindAsync(id);
            if (prod != null)
            {
                _Context.Employees.Remove(prod);
                await Save();
            }
        }

        public async Task Update(Employee model)
        {
            var Emp = await _Context.Employees.FindAsync(model.Id);
            if (Emp != null)
            {
                Emp!.FullName = model.FullName;
                Emp!.JobTitle = model.JobTitle;
                Emp!.Department = model.Department;
                Emp!.Salary = model.Salary;
                Emp!.HireDate = model.HireDate;
                _Context.Employees.Update(Emp!);
                await Save();
            }
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            var prod = await _Context.Employees.ToListAsync();
            return prod!;
        }

        public async Task<Employee> GetById(int id)
        {
            var prod = await _Context.Employees.FindAsync(id);
            return prod!;
        }
        public async Task<IEnumerable<string>> GetEmployeeNamesAsync()
        {
            var names = await _Context.Employees
                                      .Select(e => e.FullName) // تأكد أن خاصية الاسم اسمها "Name"
                                      .ToListAsync();
            return names;
        }

        private async Task Save()
        {
            await _Context.SaveChangesAsync();
        }

    }
}
