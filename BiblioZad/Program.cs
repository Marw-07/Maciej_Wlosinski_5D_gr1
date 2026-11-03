using System;

class Program
{
    static string[] ksiazki =
    {
        "Pan Tadeusz",
        "Lalka",
        "Hobbit"
    };

    static bool[] dostepne = { true, true, true };

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nBIBLIOTEKA");
            Console.WriteLine("1. Wyswietl ksiazki");
            Console.WriteLine("2. Wypozycz ksiazke");
            Console.WriteLine("3. Zwroc ksiazke");
            Console.WriteLine("4. Zakoncz program");
            Console.Write("Wybierz opcje: ");

            string wybor = Console.ReadLine();

            if (wybor == "1")
            {
                for (int i = 0; i < ksiazki.Length; i++)
                {
                    string status = dostepne[i] ? "Dostepna" : "Wypozyczona";
                    Console.WriteLine((i + 1) + ". " + ksiazki[i] + " - " + status);
                }
            }
            else if (wybor == "2")
            {
                Console.Write("Podaj numer ksiazki: ");

                if (int.TryParse(Console.ReadLine(), out int numer) &&
                    numer >= 1 && numer <= ksiazki.Length &&
                    dostepne[numer - 1])
                {
                    dostepne[numer - 1] = false;
                    Console.WriteLine("Ksiazka zostala wypozyczona.");
                }
                else
                {
                    Console.WriteLine("Nie mozna wypozyczyc tej ksiazki.");
                }
            }
            else if (wybor == "3")
            {
                Console.Write("Podaj numer ksiazki: ");

                if (int.TryParse(Console.ReadLine(), out int numer) &&
                    numer >= 1 && numer <= ksiazki.Length &&
                    !dostepne[numer - 1])
                {
                    dostepne[numer - 1] = true;
                    Console.WriteLine("Ksiazka zostala zwrocona.");
                }
                else
                {
                    Console.WriteLine("Nie mozna zwrocic tej ksiazki.");
                }
            }
            else if (wybor == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Nieprawidlowy wybor.");
            }
        }
    }
}