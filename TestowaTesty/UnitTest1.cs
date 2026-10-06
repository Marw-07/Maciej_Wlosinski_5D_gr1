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

        [Fact]
        public void MetryNaCentymetry_Test()
        {
            Przelicznik przelicznik = new Przelicznik();

            double wynik = przelicznik.MetryNaCentymetry(3);

            Assert.Equal(300.0, wynik);
        }

        [Fact]
        public void GodzinyNaMinuty_Test()
        {
            Przelicznik przelicznik = new Przelicznik();

            double wynik = przelicznik.GodzinyNaMinuty(2);

            Assert.Equal(120.0, wynik);
        }
    }
}