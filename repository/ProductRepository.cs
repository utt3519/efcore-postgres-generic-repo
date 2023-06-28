using UnitOfWorkDemo.Core.Interfaces;
using efcore_postgres_generic_repo.model;


namespace UnitOfWorkDemo.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<ProductDetail>, IProductRepository
    {
        public ProductRepository(PostgresContext dbContext) : base(dbContext)
        {

        }
    }
}