using System.Linq;

namespace CashRegistryDomain
{
    public interface IRepositoryStrategy
    {
        T GetNew<T>() where T : class;
        IQueryable<T> Get<T>();
    }
}