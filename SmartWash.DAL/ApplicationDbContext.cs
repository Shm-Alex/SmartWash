using Microsoft.EntityFrameworkCore;
using SmartWash.DAL.Models;

namespace SmartWash.DAL
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> o) :base(o)
        { 
            Database.EnsureCreated();
        }
        public DbSet<Product> Products;
        public DbSet<Buyer> Buyers;
        public DbSet<ProvidedProduct> ProvidedProducts;
        public DbSet<Sale> Sales;
        public DbSet<SaleData> SaleDatas;
        public DbSet<SalesPoint> SalesPoint;

        
    }
}