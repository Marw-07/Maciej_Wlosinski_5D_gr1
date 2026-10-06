using Testowa;
using Xunit;

namespace TestowaTesty
{
    public class TestyPrzelicznika
    {
        [Fact]
        public void KilometryNaMetry_Test()
        {
            Przelicznik przelicznik = new Przelicznik();

            double wynik = przelicznik.KilometryNaMetry(2);

            Assert.Equal(2000.0, wynik);
        }
    }
}