using Compu_Pos.Data.Context;
using Compu_Pos.Data.Implement;
using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Services;
using Compu_Pos.Data.ViewModel.Compu_Pos.Data.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Compu_Pos
{
    public static class Startup
    {
        public static ServiceProvider Initialize()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var connectionString = config.GetConnectionString("DefaultConnection");

            var services = new ServiceCollection();

            // تسجيل DbContext
            //services.AddDbContext<ApplicationDBContext>(options =>
            //    options.UseSqlServer(connectionString));

            services.AddDbContextFactory<ApplicationDBContext>(options =>
            options.UseSqlServer(connectionString));

            // تسجيل كل الكلاسات الفرعية
            services.AddScoped<IProduct_Repo, Product_Imp>();
            services.AddScoped<ICustomer_Repo, Customer_Imp>();
            services.AddScoped<IBranch_Repo, Branch_Imp>();
            services.AddScoped<ICat_Repo, Cat_Imp>();
            services.AddScoped<ICompany_Repo, Company_Imp>();
            services.AddScoped<IDelevery_Repo, Delevery_Imp>();
            services.AddScoped<IEmployee_Repo, Employee_Imp>();
            services.AddScoped<IStore_Repo, Store_Imp>();
            services.AddScoped<IUnit_Repo, Unit_Imp>();
            services.AddScoped<Iinvoice_Repo, Invoice_Imp>();
            services.AddScoped<IPurchase_Repo, Purchase_Imp>();
            services.AddScoped<ProductService>();

            return services.BuildServiceProvider();
        }
    }
}