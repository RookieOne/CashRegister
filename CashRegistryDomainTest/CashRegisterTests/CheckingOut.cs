using CashRegistryDomain;
using NUnit.Framework;

namespace CashRegistryDomainTest.CashRegisterTests
{
    [TestFixture]
    public class CheckingOut
    {
        [Test]
        public void When_register_is_not_checked_out()
        {
            int userId = 4;
            var register = new CashRegister(1);
            register.CheckOutFor(userId);

            Assert.AreEqual(userId, register.CheckedOutTo);
        }
    }
}