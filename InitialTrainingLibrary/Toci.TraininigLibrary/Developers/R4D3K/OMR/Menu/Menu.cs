using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Abstract_Class;

namespace Toci.TraininigLibrary.Developers.R4D3K.OMR.Menu
{
    public class Menu : MenuBase
    {
        protected override DateTime CreateDate { get; set; }
        protected override List<Dishes> ListOfDishes { get; set; }

        public Menu(DateTime create,List<Dishes> dishes) :base(create,dishes)
        {
            CreateDate = create;
            ListOfDishes = dishes;
        }
    }
}
