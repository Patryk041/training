using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.R4D3K.OMR.Restaurant
{
    public class PizzeriaRestaurant : Restaurant
    {
        public PizzeriaRestaurant(string country, string city, string street, int number, string name, List<IService> serList, List<IEmployee> empList, List<IRoom> roomlist) 
            : base(country,city,street,number,name,serList,empList,roomlist)
        {
            RestaurantAddress = new Address(country, city, street, number);
            RestaurantName = name;
            KindRestaurant = KindOfResteurant.Pizzeria;
            ServiceList = serList;
            EmployeeList = empList;
            RoomList = roomlist;
        }

        public override string DoWork()
        {
            return "DoPizza";
        }
    }
}
