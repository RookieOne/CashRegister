using System;
using System.Linq;

namespace CashRegistryDomain
{
    public class CashRegisterRepository : ICashRegisterRepository
    {
        private readonly IRepositoryStrategy _strategy;

        public CashRegisterRepository(IRepositoryStrategy strategy)
        {
            _strategy = strategy;
        }

        public CashRegister GetNextAvailableRegister()
        {
            return null;
        }

        public CashRegister Create()
        {
            throw new NotImplementedException();
        }
    }
}