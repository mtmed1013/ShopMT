using Microsoft.EntityFrameworkCore;
using ShopMT.Web.Data.Entities;

namespace ShopMT.Web.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

    }
}
