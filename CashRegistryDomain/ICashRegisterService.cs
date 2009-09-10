namespace CashRegistryDomain
{
    public interface ICashRegisterService
    {
        int RequisitionRegister(RequisitionRegisterMessage message);
    }
}