using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Interfaces;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Restaurant;

namespace Toci.TraininigLibrary.Developers.R4D3K.OMR.Abstract_Class
{
    public abstract class RestaurantBase : IRestaurant
    {
        protected string RestaurantName { get; set; }
        protected Address RestaurantAddress { get; set; }
        protected KindOfResteurant KindRestaurant { get; set; }
        protected List<IService> ServiceList { get; set; }
        protected List<IEmployee> EmployeeList { get; set; }
        protected List<IRoom> RoomList { get; set; }
        protected RestaurantBase(string country, string city, string street,int number,string name,List<IService> serList,List<IEmployee> empList,List<IRoom> roomlist)
        {
            
        }
        public abstract Address GetAddress();
        public abstract List<IEmployee> GetEmployees();
        public abstract List<IService> GetService();
        public abstract string GetName();
        public abstract string DoWork();
    }
}
