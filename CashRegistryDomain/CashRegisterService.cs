using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashRegistryDomain
{
    public class CashRegisterService : ICashRegisterService
    {
        private readonly ICashRegisterRepository _repository;

        public CashRegisterService(ICashRegisterRepository repository)
        {
            _repository = repository;
        }

        public int RequisitionRegister(RequisitionRegisterMessage message)
        {
            return 0;
        }
    }
}
