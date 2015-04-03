using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Dysq.omr.Interface;
using Toci.TraininigLibrary.Developers.Dysq.omr.Moves;
using Toci.TraininigLibrary.Developers.Dysq.omr.SportsManModel;

namespace Toci.TraininigLibrary.Developers.Dysq.omr
{
    public class Player : SportsManBase
    {
      
        private BodyPartsMovesBase _moveSomething;

        public Player(int age, string name, string surname, double height, double weight, int agi, int str, KindOfSport sportName, int exp) : base(age, name, surname, height, weight, agi, str, sportName, exp)
        {
            this.Age = age;
            this.Name = name;
            this.Surname = surname;
            this.Height = height;
            this.Weight = weight;
            this.Agility = agi;
            this.Strenght = str;
            this.SportsField = sportName;
            this.ExperienceInYears = exp;
            
        }

        public void MoveHead(int x, int y, int z)
        {
            _moveSomething = new PlayerMoves(x, y, z);
            _moveSomething.MoveHead(x, y, z);
        }
        public void MoveRightHand(int x, int y, int z)
        {
            _moveSomething = new PlayerMoves(x, y, z);
            _moveSomething.MoveRightHand(x, y, z);
        }
        public void MoveLeftHand(int x, int y, int z)
        {
            _moveSomething = new PlayerMoves(x, y, z);
            _moveSomething.MoveLeftHand(x, y, z);
        }

        public void MoveRightLeg(int x, int y, int z)
        {
            _moveSomething = new PlayerMoves(x, y, z);
            _moveSomething.MoveRightLeg(x, y, z);
        }
        public void MoveLeftLeg(int x, int y, int z)
        {
            _moveSomething = new PlayerMoves(x, y, z);
            _moveSomething.MoveLeftLeg(x, y, z);
        }

    }
}
