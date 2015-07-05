using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Kalisz.Amman.PeselValidator;
using Toci.Hornets.Kalisz.Amman.StringManipulator;
using Toci.Hornets.Kalisz.Amman.StringManipulator.Workers;

namespace Toci.Hornets.UnitTests.Kalisz.Amman
{
    [TestClass]
    public class UnitTester
    {
        [TestMethod]
        public void StringceptionTest()
        {
            string[][] words =
            {
                new string[] {"Amman", "mm"}, 
                new string[]{"Amman", "Amm"}, 
                new string[]{"Amman", "amm"}, 
                new string[]{"Amman", "man"}, 
                new string[]{"Amman", "nam"},
                new string[]{"Amman", "b"}, 
                new string[]{"Amman", "dsa"}, 
                new string[]{"fsdsfad", "fdsfds"}, 
                new string[]{"Amman", "nammA"}, 
                new string[]{"Amman", "Aammn"}, 
                new string[]{"Amman", "aAnmn"}, 
                new string[]{"fdsff", "njvkdsb"},
                new string[]{"quid est veritas", "vir est quiadest"}, 
                new string[]{"salvador dali", "avida dollars"}, 
                new string[]{"julian tuwim", "lutni ujawmi"}, 

            };
            var stringceptions = new List<string[]>();
            var stringElements = new List<string[]>();
            var anagrams = new List<string[]>();

            foreach (var pair in words)
            {
                var unit = new AmmanStringCheck().RunStringOperations(pair[0], pair[1]);
                if (unit.IsAnagram) anagrams.Add(pair);
                if (unit.IsStringElementsInString) stringElements.Add(pair);
                if (unit.IsStringInString) stringceptions.Add(pair);
            }
            Assert.AreEqual(stringceptions.Count,3);
            Assert.AreEqual(stringElements.Count,12);
            Assert.AreEqual(anagrams.Count,6);
        }
        [TestMethod]
        public void PeselValidationTest()
        {
            var validPesels = new List<string>
            {
                "95121715083",
                "57031312507",
                "41030516093",
                "66042212311",
                "81061912033",
                "64101306575",
                "29071211739",
                "38012100481",
                "61111009591",
                "71022507224",
            };

            var invalidPesels = new List<string> //just random numbers, let's hope it's not actual PESEL
            {
                "123489611468",
                "1f6ds1f64f4",
                "123132456",
                "6786d78s9",
                "8908908989",
                "0000000000",
                "dsadwdwff11",
                "bfyhjbfhyjdf",
                "25616148013",
                "44885566331",
                "1"
            };
            var validator = new AmmanPeselValidator();
            foreach (var psl in validPesels)
            {
                Assert.IsTrue(validator.IsPeselValid(psl));
            }
            foreach (var psl in invalidPesels)
            {
                Assert.IsFalse(validator.IsPeselValid(psl));
            }

        }

        [TestMethod]
        public void BatchAnagramTest()
        {
            var tekst =
                "Jak co roku obchody lanego poniedziałku w Bełchatowie wywołują wiele emocji. Święto to jest, co prawda, uświęcone tradycją, " +
                "jednakże są ludzie, którzy zdecydowanie przesadzają z hołdowaniem tej jednej tradycji. „Świństwo, kiedyś to dziewczyny się perfumami " +
                "lało, a nie tak, jak teraz, wiadrami; tałatajstwo!!!”, oburza się starszy pan, zapytany o opinię na temat nadchodzącego poniedziałku. " +
                "W ubiegłym roku śmigus- dyngus okazał się wyjątkowo mokry i wyjątkowo brzemienny w skutkach. W wyniku „niewinnych” igraszek z wodą doszło " +
                "do wypadku samochodowego, w wyniku którego jedna osoba doznała poważnych obrażeń kręgosłupa. Było to na szczęście jedyne tak tragiczne" +
                " wydarzenie owego dnia. Wczoraj o godzinie osiemnastej odbyło się zebranie Stowarzyszenia Bełchatowskich Rodzin, na którym omawiano drażniący " +
                "problem lanego poniedziałku. Wysunięto także propozycję, aby na ulicę wyszły prewencyjnie liczniejsze niż zwykle patrole policji i straży " +
                "miejskiej. Rodziny zaapelowały do młodzieży, żeby ta nie przesadzała z wodą. Tymczasem sama młodzież mówi, że nic złego się nigdy nie dzieje. " +
                "„My się oblewamy między sobą, serio. Na pewno do żadnego dorosłego kolesia z butlami nie przylecimy. Nie wiem, czemu wszyscy tak się tego " +
                "poniedziałku boją!”. Koledzy mojego rozmówcy tylko przytakują głowami. Nie ulega wątpliwości, że temat lanego poniedziałku wywołał liczne " +
                "komentarze i wątpliwości, zarówno po stronie amatorów tego tradycyjnego polskiego obrzędu, jak i po stronie bełchatowian obawiających się o " +
                "swoje bezpieczeństwo. Obecnie można tylko czekać na decyzję kompetentnych organów i poważnie się zastanowić nad problemem śmigusa- dyngusa. " +
                "okur";
            var result = BatchAnagram.Go(tekst);


        }


    }
}