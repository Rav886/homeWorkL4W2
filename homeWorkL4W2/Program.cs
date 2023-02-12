using System;
using System.Reflection.Metadata;

namespace homeWorkL4W2
{

    class Program
    {
        public const string FILE_NAME = @"C:\Szkolenie\homrWorkL4W2.xlsx";

        

        public static void Main(string[] args)
        {
            int age;
            ulong persnum, num;
            Console.WriteLine("Podaj imię pracownika");

            string name = Console.ReadLine();

            Console.WriteLine($"Wprowadzone imię to: {name}");

            Console.WriteLine("Podaj Nazwisko pracownika");

            string surname = Console.ReadLine();

            Console.WriteLine($"Wprowadzone nazwisko to: {surname}");

            Console.WriteLine("Podaj wiek pracownika");

            age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Wprowadzony wiek to: {age}");

                 

            Console.WriteLine("Podaj płeć pracownika \"m\" mężczyzna, \"k\" kobieta ");

            string sex = Console.ReadLine();

            Console.WriteLine($"Wprowadzona płeć to: {sex}");

            Console.WriteLine("Podaj PESEL");

            persnum = ulong.Parse(Console.ReadLine());

            Console.WriteLine($"Podany pesel to: {persnum}");

            Console.WriteLine("Podaj numer pracownika");

            num = ulong.Parse(Console.ReadLine());

            Console.WriteLine($"Podany numer pracownika to: {num}");

        } 
    }
}