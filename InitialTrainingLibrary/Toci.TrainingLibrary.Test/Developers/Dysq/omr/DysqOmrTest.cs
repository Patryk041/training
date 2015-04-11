using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Dysq.omr;
using Toci.TraininigLibrary.Developers.Dysq.omr.Moves;
using Toci.TraininigLibrary.Developers.Dysq.omr.Skills;
using Toci.TraininigLibrary.Developers.Dysq.omr.SportsManModel;

namespace Toci.TrainingLibrary.Test.Developers.Dysq.omr
{   
   [TestClass]
   public class DysqOmrTest
    {
            [TestMethod]
            public void DysqPlayerTest()
            {
              var testPlayer = new FootballPlayer(18,"Jan","Kowalski",1.84, 80.00, 8, 8, 2);

                var testSecondPlayer = new FootballPlayer(20, "Marek", "Nowak", 1.70, 75, 9, 7, 1);
                
                testPlayer.LearnSkill("zonglerka",8,7);
                
                testPlayer.LearnSkill("strzal", 9, 6);

                var skills = testPlayer.GetPlayerSkills();

                testPlayer.ImproveSkill("strzal",2,3);

                testPlayer.ImproveSkill("zonglerka",2,3);

                var skillToUse=testPlayer.ChoseAndUseSkill("strzal");

                testPlayer.MoveHead(0, 3, 4);
                //testPlayer.MoveRightHand(0, 3, 4);
                //testPlayer.MoveLeftHand(0, 4, 5);
                //testPlayer.MoveRightLeg(3, 5, 0);
                //testPlayer.MoveLeftLeg(4, 6, 0);
              
            }

    }
}
