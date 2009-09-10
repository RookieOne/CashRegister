namespace CashRegistryDomain
{
    public class RequisitionRegisterMessage
    {
        private RequisitionRegisterMessage(int userId)
        {
            UserId = userId;
        }

        public virtual int UserId { get; protected set; }

        public static RequisitionRegisterMessage For(int userId)
        {
            return new RequisitionRegisterMessage(userId);
        }
    }
}