using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> purchaseHistory = new Stack<string>();

        purchaseHistory.Push("Телефон");
        purchaseHistory.Push("Навушники");
        purchaseHistory.Push("Телевізор");

        Console.WriteLine($"Остання купівля: {purchaseHistory.Peek()}");

        Console.WriteLine("\nІсторія покупок:");
        foreach (var item in purchaseHistory)
        {
            Console.WriteLine($"{item}");
        }
    }
}
