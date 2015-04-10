using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Interfaces;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Service;

namespace Toci.TraininigLibrary.Developers.R4D3K.OMR.Abstract_Class
{
    public abstract class ServiceBase : IService
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal Cost { get; set; }
        protected KindOfService KindService { get; set; }
        protected ServiceBase(int id,string name,decimal cost)
        {
            
        }
    }
}
