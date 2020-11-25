using System;
using ECommerce;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il tuo nome");
            string name = Console.ReadLine();
            string toUpper = name.ToUpper();
            System.Console.WriteLine( "Il nome inserito in maiuscolo è" +" "+ toUpper);
        }
    }
}


