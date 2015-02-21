using System;
using InitialTrainingLibrary.frogie;
using InitialTrainingLibrary.syf.privatelol;

namespace InitialTrainingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FrogieDate date = new FrogieDate();

            Console.WriteLine("Podaj rok:");

            var line = Console.ReadLine();

            date.UstawRok(int.Parse(line));

            Console.WriteLine("Podaj miesiac:");

            var line2 = Console.ReadLine();

            date.UstawMiesiac(int.Parse(line2));

            Console.WriteLine("Podaj dzien:");

            var line3 = Console.ReadLine();

            date.UstawDzien(int.Parse(line3));

            FrogieDateValidator validator = new FrogieDateValidator();
            var valid = validator.DateValidate(date.PodajRok(), date.PodajMiesiac(), date.PodajDzien());

            if (valid)
            {
                Console.WriteLine("data jest ok");
            }
            else
            {
                Console.WriteLine("data jest walnieta");
            }

            Console.ReadKey();
        }
    }
}
