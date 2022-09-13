using System.Data.Entity;
using WAD_T2104E_BuiManhTuan.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WAD_T2104E_BuiManhTuan.Context
{
    public class ProductManagementContext : DbContext
    {
        public ProductManagementContext() : base("BuiManhTuanDB")
        { }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}