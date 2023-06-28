using efcore_postgres_generic_repo.model;

namespace UnitOfWorkDemo.Core.Interfaces
{
    public interface IProductRepository : IGenericRepository<ProductDetail>
    {
    }
}