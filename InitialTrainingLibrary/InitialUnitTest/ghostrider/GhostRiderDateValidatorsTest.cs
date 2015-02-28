using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Chmura.DateTimeValidator;
using InitialTrainingLibrary.ghostrider;
using InitialTrainingLibrary.Interfaces;
using InitialTrainingLibrary.KrzysiuRysiu._1.DateValidator;
using InitialTrainingLibrary.RS.Simple;
using InitialTrainingLibrary.Sito._1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InitialTrainingLibrary.syf.disposable;

namespace InitialUnitTest.ghostrider
{
    [TestClass]
    public class GhostRiderDateValidatorsTest
    {
        [TestMethod]
        public void GEnericsTest()
        {
            Logic logic = new Logic();
            logic.RunFileRead();

            var s = HipcioSingleton.GetInstance();

            s.test();
        }

        [TestMethod]
        public void TestAllValidators()
        {
            List<IDateValidator> validators = new List<IDateValidator>()
            {
                new InitialTrainingLibrary.Chmura.DateTimeValidator.DateValidator(),
                new InitialTrainingLibrary.Sito._1.DateValidator(),
                new InitialTrainingLibrary.RS.Simple.DateValidator()
            };

            List<ValidationEntry> validationEntries = new List<ValidationEntry>();

            foreach (var validator in validators)
            {
                var valEntry = new ValidationEntry();

                valEntry.Name = validator.GetName();

                var start = DateTime.Now.Millisecond;

                bool result = validator.DateValidate(2012, 2, 22);

                var end = DateTime.Now.Millisecond;

                valEntry.Time = end - start;

                if (!result)
                {
                    valEntry.Errors.Add(string.Format("{0}-{1}-{2}", 2012, 2, 22));
                }

                validationEntries.Add(valEntry);
            }

            foreach (var validationEntry in validationEntries)
            {
                Debug.WriteLine("name: {0}, time: {1}, err: {2}", validationEntry.Name, validationEntry.Time, validationEntry.Errors == null ? string.Empty : validationEntry.Errors.FirstOrDefault());
            }
        }
    }

    class ValidationEntry
    {
        public string Name { get; set; }

        public int Time { get; set; }

        public List<string> Errors { get; set; } 
    }
}
