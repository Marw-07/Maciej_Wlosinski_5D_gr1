using System;
using System.IO;

public class Program
{
    static string[] ksiazki =
    {
        "Pan Tadeusz",
        "Lalka",
        "Hobbit"
    };

    static bool[] dostepne = { true, true, true };

    public static void Main()
    {
        Uruchom(Console.In, Console.Out);
    }

    public static void Uruchom(TextReader wejscie, TextWriter wyjscie)
    {
        dostepne = new bool[] { true, true, true };

        while (true)
        {
            wyjscie.WriteLine("\nBIBLIOTEKA");
            wyjscie.WriteLine("1. Wyswietl ksiazki");
            wyjscie.WriteLine("2. Wypozycz ksiazke");
            wyjscie.WriteLine("3. Zwroc ksiazke");
            wyjscie.WriteLine("4. Zakoncz program");
            wyjscie.Write("Wybierz opcje: ");

            string wybor = wejscie.ReadLine();

            if (wybor == "1")
            {
                for (int i = 0; i < ksiazki.Length; i++)
                {
                    string status = dostepne[i] ? "Dostepna" : "Wypozyczona";
                    wyjscie.WriteLine((i + 1) + ". " + ksiazki[i] + " - " + status);
                }
            }
            else if (wybor == "2")
            {
                wyjscie.Write("Podaj numer ksiazki: ");

                if (int.TryParse(wejscie.ReadLine(), out int numer) &&
                    numer >= 1 && numer <= ksiazki.Length &&
                    dostepne[numer - 1])
                {
                    dostepne[numer - 1] = false;
                    wyjscie.WriteLine("Ksiazka zostala wypozyczona.");
                }
                else
                {
                    wyjscie.WriteLine("Nie mozna wypozyczyc tej ksiazki.");
                }
            }
            else if (wybor == "3")
            {
                wyjscie.Write("Podaj numer ksiazki: ");

                if (int.TryParse(wejscie.ReadLine(), out int numer) &&
                    numer >= 1 && numer <= ksiazki.Length &&
                    !dostepne[numer - 1])
                {
                    dostepne[numer - 1] = true;
                    wyjscie.WriteLine("Ksiazka zostala zwrocona.");
                }
                else
                {
                    wyjscie.WriteLine("Nie mozna zwrocic tej ksiazki.");
                }
            }
            else if (wybor == "4" || wybor == null)
            {
                break;
            }
            else
            {
                wyjscie.WriteLine("Nieprawidlowy wybor.");
            }
        }
    }
}