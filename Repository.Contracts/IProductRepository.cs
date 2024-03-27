using Entities.Models;

namespace Repository.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges);
        Task<Product> GetProductAsync(Guid productId, bool trackChanges);
        void CreateProduct(Product product);
        Task<IEnumerable<Product>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        void DeleteProduct(Product company);
    }
}
