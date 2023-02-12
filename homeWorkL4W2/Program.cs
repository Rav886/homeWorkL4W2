using System;


namespace homeWorkL4W2
{

    class Program
    {
        public const string FILE_NAME = @"C:\Szkolenie\homrWorkL4W2.xlsx";

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj imię pracownika");

            string name = Console.ReadLine();

            Console.WriteLine($"Wprowadzone imię to: {name}");

            Console.WriteLine("Podaj Nazwisko pracownika");

            string surname = Console.ReadLine();

            Console.WriteLine($"Wprowadzone nazwisko to: {surname}");

            Console.WriteLine("Podaj wiek pracownika");

            object Int = null;

            int age = Console.ReadLine();
            Int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine($"Wprowadzony wiek to: {age}");

            Console.WriteLine("Podaj płeć pracownika \"m\" mężczyzna, \"k\" kobieta ");

            string sex = Console.ReadLine();

            Console.WriteLine($"Wprowadzona płeć to: {sex}");
        }

    }
}