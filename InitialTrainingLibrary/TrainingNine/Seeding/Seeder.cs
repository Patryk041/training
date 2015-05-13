using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrainingNine.Models;

namespace TrainingNine.Seeding
{
    public static class Seeder
    {
        public static PeopleCollection SeedPeople()
        {
            return new PeopleCollection
            {
                 new People() { Age = 28, Gender = "male", Name = "Mg", Surname = "Kowalski"},
                 new People() { Age = 43, Gender = "male", Name = "Mg", Surname = "Nowak"},
                 new People() { Age = 65, Gender = "male", Name = "Mg", Surname = "Kwiatkowski"},
                 new People() { Age = 67, Gender = "male", Name = "Mg", Surname = "Kukiz"},
                 new People() { Age = 23, Gender = "male", Name = "Mg", Surname = "Muniek"},
                 new People() { Age = 34, Gender = "male", Name = "Mg", Surname = "Wojwodzki"},
                 new People() { Age = 45, Gender = "male", Name = "Mg", Surname = "Powiatowy"},
                 new People() { Age = 84, Gender = "male", Name = "Mg", Surname = "Gminny"},
            
            };
        }
    }
}