using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Abstract_Class;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.R4D3K.OMR.Restaurant
{
    public class Restaurant : RestaurantBase
    {
        public Restaurant(string country, string city, string street, int number, string name, List<IService> serList, List<IEmployee> empList,List<IRoom> roomlist) 
            : base(country,city,street,number,name,serList,empList,roomlist)
        {
            RestaurantAddress = new Address(country, city, street, number);
            RestaurantName = name;
            ServiceList = serList;
            EmployeeList = empList;
            RoomList = roomlist;
        }
        public override Address GetAddress()
        {
            return RestaurantAddress;
        }

        public override List<IEmployee> GetEmployees()
        {
            return EmployeeList;
        }

        public override List<IService> GetService()
        {
            return ServiceList;
        }
        public override string GetName()
        {
            return RestaurantName;
        }
        public override string DoWork()
        {
            return "DoOrder";
        }
    }
}
