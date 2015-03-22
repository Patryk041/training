using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Dysq
{
    public class Player : SportsMan, IDisposable
    {
        public Player() : base(12, "", "", "")
        {
            
        }

        public Player(int age, string name, string surname, string SportsField) : base(age, name, surname, SportsField)
        {
           // var dupa = new SportsMan(12,"dfsa", "dfsa", "dsfaf");
        }


        public override bool DoesHeWantToTrick(SportsmanSkill trick)
        {
            //var test = base.DoesHeWantToTrick(trick);

            return true;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();

            //zamykamy polaczenia do bazy
            //zamykamy plik
            //czyscimy tablce

        }
    }
}
