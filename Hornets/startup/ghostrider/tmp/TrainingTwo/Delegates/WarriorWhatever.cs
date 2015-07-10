using System;
using System.Collections.Generic;
using Toci.Hornets.GhostRider.TrainingTwo.Homework;

namespace Toci.Hornets.GhostRider.TrainingTwo.Delegates
{
    public class WarriorWhatever
    {
        private Dictionary<string, Func<SomeModel, string>> slownikKonwersji = new Dictionary
            <string, Func<SomeModel, string>>()
        {
            {"Field", model => model.Field},
            {"Ofc", model => { TestDelegation(); return model.Ofc.ToString(); } },
        };


        public void DoComputation<T>(T item) where T : SomeModel
        {
            GhostRoderPeselValidator v = new GhostRoderPeselValidator();

            foreach (var thing in slownikKonwersji)
            {
                v.IsPeselValid(thing.Value(item));
              
            }

            v.IsPeselValid(item.ToString());
        }

        private static void TestDelegation()
        {
            
        }
    }
}