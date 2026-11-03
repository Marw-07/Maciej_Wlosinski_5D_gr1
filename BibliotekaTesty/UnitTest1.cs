using System.IO;
using Xunit;

public class TestyBiblioteki
{
    [Fact]
    public void UzytkownikMozeWypozyczycDostepnaKsiazke()
    {
        string dane = "2\n1\n1\n4";
        StringReader wejscie = new StringReader(dane);
        StringWriter wyjscie = new StringWriter();

        Program.Uruchom(wejscie, wyjscie);

        string wynik = wyjscie.ToString();

        Assert.Contains("Ksiazka zostala wypozyczona.", wynik);
        Assert.Contains("Pan Tadeusz - Wypozyczona", wynik);
    }


    [Fact]
    public void UzytkownikNieMozeWypozyczycTejSamejKsiazkiDwaRazy()
    {
        string dane = "2\n1\n2\n1\n4";
        StringReader wejscie = new StringReader(dane);
        StringWriter wyjscie = new StringWriter();

        Program.Uruchom(wejscie, wyjscie);

        string wynik = wyjscie.ToString();

        Assert.Contains("Ksiazka zostala wypozyczona.", wynik);
        Assert.Contains("Nie mozna wypozyczyc tej ksiazki.", wynik);
    }


    [Fact]
    public void UzytkownikMozeZwrocicWypozyczonaKsiazke()
    {
        string dane = "2\n1\n3\n1\n1\n4";
        StringReader wejscie = new StringReader(dane);
        StringWriter wyjscie = new StringWriter();

        Program.Uruchom(wejscie, wyjscie);

        string wynik = wyjscie.ToString();

        Assert.Contains("Ksiazka zostala wypozyczona.", wynik);
        Assert.Contains("Ksiazka zostala zwrocona.", wynik);
        Assert.Contains("Pan Tadeusz - Dostepna", wynik);
    }

}