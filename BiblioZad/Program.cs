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
                    Console.WriteLine(ksiazki[i] + " - " + status);
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