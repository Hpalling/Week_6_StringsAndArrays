using System;

namespace StrindsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //prog küsib eesnime
            //prog kuvab nime pikkuse

            Console.WriteLine("sisesta eesnimi");
            string firstName = Console.ReadLine();

            //int firstNameLenght = firstName.Lenght;
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");
        }
    }
}

