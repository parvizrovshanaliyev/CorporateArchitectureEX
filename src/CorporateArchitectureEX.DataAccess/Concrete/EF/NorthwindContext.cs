using CorporateArchitectureEX.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CorporateArchitectureEX.DataAccess.Concrete.EF
{
    public class NorthwindContext:DbContext
    {
        #region Overrides of DbContext

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }

        #endregion

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
