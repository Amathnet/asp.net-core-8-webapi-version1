using AutoMapper;
using Service.Contracts;
using Repository.Contracts;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductService> _productService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _productService = new Lazy<IProductService>(() => new ProductService(repositoryManager, logger, mapper));
        }

        public IProductService ProductService => _productService.Value;
    }
}
