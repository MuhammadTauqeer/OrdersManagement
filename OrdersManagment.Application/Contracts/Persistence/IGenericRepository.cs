using OrdersManagment.Domain.Common;

namespace OrdersManagment.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : BaseDomainEntity
    {
        Task<T> Get(int id);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Add(T entity);
        Task<bool> Exists(int id);
        Task Update(T entity);
        Task Delete(T entity);

    }
}
