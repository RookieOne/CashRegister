namespace CashRegistryDomain
{
    public class CashRegister
    {
        public CashRegister(int id)
        {
            Id = id;
        }

        public virtual int Id { get; protected set; }
        public virtual int CheckedOutTo { get; protected set; }

        public void CheckOutFor(int userId)
        {
            CheckedOutTo = userId;
        }
    }
}