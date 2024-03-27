using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync(bool trackChanges);
        Task<ProductDto> GetProductAsync(Guid productId, bool trackChanges);
        Task<ProductDto> CreateProductAsync(ProductForCreationDto product);
        Task<IEnumerable<ProductDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        Task<(IEnumerable<ProductDto> products, string ids)> CreateProductCollectionAsync
            (IEnumerable<ProductForCreationDto> productCollection);
        Task DeleteProductAsync(Guid productId, bool trackChanges);
        Task UpdateProductyAsync(Guid productid, ProductForUpdateDto productForUpdate, bool trackChanges);
    }
}
