using System;
using DemoApplication.Demo.Interfaces;

namespace DemoApplication.Demo.AccessModifiers
{
    public  class Human : IHuman, IRobot
    {
        protected Brain Brain;
        private int dsafad = 342;

        public void See(Human anotherHuman)
        {
            //dfaegfgtdsg
        }

        public int GetGender(Func<Human, int> recDelegate)
        {
            //calldoctor
            //.RemovePanties();
            dsafad = 4325;
            return Recognize(recDelegate);//
        }

        protected virtual int Recognize(Func<Human, int> recDelegate)
        {
            return recDelegate(this);
        }

        public void Think(IBrain brain)
        {
            throw new NotImplementedException();
        }
    }
}