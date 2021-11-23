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
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void IsPrime_InputIs1_ReturnFalse(int value)
        {
            bool result = _primeService.IsPrime(value);
            Assert.IsFalse(result, "{value} should not be a prime");
        }

    }
}
