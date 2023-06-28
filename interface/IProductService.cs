using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using efcore_postgres_generic_repo.model;

namespace UnitOfWorkDemo.Services.Interfaces
{
    public interface IProductService
    {
        Task<bool> CreateProduct(ProductDetail productDetails);

        Task<IEnumerable<ProductDetail>> GetAllProducts();

        Task<ProductDetail> GetProductById(int productId);

        Task<bool> UpdateProduct(ProductDetail productDetails);

        Task<bool> DeleteProduct(int productId);
    }
}