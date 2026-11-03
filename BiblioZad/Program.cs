using System;

class Program
{
    static string[] ksiazki =
    {
        "Pan Tadeusz",
        "Lalka",
        "Hobbit"
    };

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
                foreach (string ksiazka in ksiazki)
                {
                    Console.WriteLine(ksiazka);
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