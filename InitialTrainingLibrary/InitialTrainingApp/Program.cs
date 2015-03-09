using System;
using System.Collections.Generic;
using System.Linq;
using InitialTrainingLibrary.dysq.Chess;
using InitialTrainingLibrary.frogie;
using InitialTrainingLibrary.syf.privatelol;
using InitialTrainingLibrary.TrainingThree.Extensions;

namespace InitialTrainingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string dsaf = "dafads";

            dsaf.IsPalindrom();

            Dictionary<string, string> test234 = new Dictionary<string, string>();

            test234.Add("vnth", "ehgdqsyfgqeyfiads");
            test234.Add("vnthdsa", "ehgdqsyfgqeyfiads");
            test234.Add("vnthdsadfsagfads", "ehgdqsyfgqeyfiads");
            test234.Add("vnthdsadfsagfadsfsadfd", "ehgdqsyfgqeyfiads");
            test234.Add("betti", "ehgdqsyfgqeyfiads");

            test234.Where(kvpel => kvpel.Key.IsPalindrom());
            //var result =  test234.Where(kvpel => kvpel.Key.is == "vnth");

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

            CreateFigures ShowMyChess = new CreateFigures();

            Console.ReadKey();

        }
    }
}
