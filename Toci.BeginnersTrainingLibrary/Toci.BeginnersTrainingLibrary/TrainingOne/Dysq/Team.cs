using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Dysq
{
    public class Team
    {
        private string TeamName;

        public Team(string name)
        {
            TeamName = name;
        }

        List<SportsMan> MembersList = new List<SportsMan>();

        public List<SportsMan> CreateTeam()
        {
            Player Mateusz = new Player(14,"Mateusz","Byra","Football");

            MembersList.Add(Mateusz);

            MembersList.Add(new Player(18,"Jan","Kowalski","Football"));
            MembersList.Add(new Player(18,"Jan","Sobieski","Football"));


            return MembersList;
        }

        public string GetTeamName()
        {
            return TeamName;
        }
    }
}
