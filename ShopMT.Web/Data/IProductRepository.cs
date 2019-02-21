namespace ShopMT.Web.Data
{
    using System.Linq;
    using Entities;

    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable GetAllWithUsers();
    }


}
