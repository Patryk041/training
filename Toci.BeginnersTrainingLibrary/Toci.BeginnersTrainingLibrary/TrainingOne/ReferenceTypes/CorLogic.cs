using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Factory;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.ReferenceTypes
{
    public class CorLogic
    {
        public void Fire()
        {
            var entity = new RandomEntity();

            var nameHandler = new ManipulateNameHandle();
            var nickHandler = new ManipulateNickHandle();
            var skillHandler = new ManipulateSkillHandle();

            nameHandler.Handle(entity);
            nickHandler.Handle(entity);
            skillHandler.Handle(entity);

            var test = entity.Name;


            IChainOfResponsibilityFriendly[] chain = new IChainOfResponsibilityFriendly[] { new ManipulateNameHandle(), new ManipulateNickHandle(), new ManipulateSkillHandle()};
            var newEntity = new RandomEntity();

            foreach (var item in chain)
            {
                item.Handle(newEntity);
            }

        }

        public void TestFactory()
        {
            var opel = CarFactory.CreateCar("dfsagfds");
        }
    }
}
