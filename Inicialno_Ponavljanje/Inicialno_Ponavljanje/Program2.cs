using System;

internal class Program2
{
    static void Main2(string[] args)
    {
        {
            Console.WriteLine("Unesite niz znakova:");
            string inputString = Console.ReadLine();
          
            string modifiedString = inputString.Replace(' ', '_');

            Console.WriteLine("Izmijenjeni niz znakova:");
            Console.WriteLine(modifiedString);
            Console.ReadKey();
        }

    }
}
