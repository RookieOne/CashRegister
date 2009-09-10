using System;
using System.Collections.Generic;
using System.Linq;

namespace CashRegistryDomain
{
    public class MemoryRepositoryStrategy : IRepositoryStrategy
    {
        private readonly List<object> _database;

        public MemoryRepositoryStrategy()
        {
            _database = new List<object>();
        }

        public IQueryable<T> Get<T>()
        {
            return _database
                .Where(o => o.GetType() == typeof (T))
                .Cast<T>()
                .AsQueryable();
        }

        public T GetNew<T>() where T : class
        {
            var count = _database
                .Where(o => o.GetType() == typeof (T))
                .Cast<T>()
                .Count();

            var instance = new CashRegister(count++);

            _database.Add(instance);                        

            return instance as T;
        }
    }
}