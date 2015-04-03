using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Dysq.omr;
using Toci.TraininigLibrary.Developers.Dysq.omr.Moves;
using Toci.TraininigLibrary.Developers.Dysq.omr.SportsManModel;

namespace Toci.TrainingLibrary.Test.Developers.Dysq.omr
{   
   [TestClass]
   public class DysqOmrTest
    {
            [TestMethod]
            public void DysqPlayerTest()
            {
              var testPlayer = new Player(18,"Jan","Kowalski",1.84, 80.00, 8, 8, KindOfSport.Football, 2);

                testPlayer.SkillName = "zonglerka";
                testPlayer.LearnSkill();

                testPlayer.MoveHead(0, 3, 4);
                testPlayer.MoveRightHand(0, 3, 4);
                testPlayer.MoveLeftHand(0, 4, 5);
                testPlayer.MoveRightLeg(3, 5, 0);
                testPlayer.MoveLeftLeg(4, 6, 0);
              
            }

    }
}
