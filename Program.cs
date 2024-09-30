using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Skapa en kö för att hantera kunder i kön
        Queue<string> ko = new Queue<string>();

        // Simulera köprocessen
        Console.WriteLine("Kön är tom, ICA öppnar.");

        // Kalle ställer sig i kön
        ko.Enqueue("Kalle");
        Console.WriteLine("Kalle ställer sig i kön.");

        // Greta ställer sig i kön
        ko.Enqueue("Greta");
        Console.WriteLine("Greta ställer sig i kön.");

        // Kalle blir expedierad och lämnar kön
        Console.WriteLine($"{ko.Dequeue()} blir expedierad och lämnar kön.");

        // Stina ställer sig i kön
        ko.Enqueue("Stina");
        Console.WriteLine("Stina ställer sig i kön.");

        // Greta har handlat och lämnar kön
        Console.WriteLine($"{ko.Dequeue()} blir expedierad och lämnar kön.");

        // Olle ställer sig i kön
        ko.Enqueue("Olle");
        Console.WriteLine("Olle ställer sig i kön.");

        // Visa statusen på kön
        Console.WriteLine("Nuvarande status på kön:");
        foreach (var person in ko)
        {
            Console.WriteLine(person);
        }
    }
}
