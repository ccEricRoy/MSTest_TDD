using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeService.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        private readonly Prime.Services.PrimeService _primeService;
        public PrimeService_IsPrimeShould()
            {
            _primeService = new Prime.Services.PrimeService();
            }

        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            bool result = _primeService.IsPrime(1);
            Assert.IsFalse(result, "1 should not be a prime");
        }

    }
}
