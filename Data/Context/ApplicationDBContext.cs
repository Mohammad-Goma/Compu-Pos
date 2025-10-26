using Compu_Pos.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Compu_Pos.Data.Context
{
    public class ApplicationDBContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>
            options) : base(options) { }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<InvoiceReturn> InvoiceReturns { get; set; }
        public DbSet<Invoice_ReturnItem> ReturnItems { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }
        public DbSet<PurchaseReturn> PurchaseReturns { get; set; }
        public DbSet<Purchase_ReturnItem> Purchase_ReturnItems { get; set; }
        public DbSet<Logo> Logos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Delevery> Deleveries { get; set; }
    }
}
