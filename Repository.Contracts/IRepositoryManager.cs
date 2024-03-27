namespace Repository.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        Task SaveAsync();
    }
}
