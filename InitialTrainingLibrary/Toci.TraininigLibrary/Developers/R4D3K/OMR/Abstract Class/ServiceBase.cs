using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.R4D3K.OMR.Abstract_Class
{
    public abstract class ServiceBase
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal Cost { get; set; }

        protected ServiceBase(int id,string name,decimal cost)
        {
            
        }
    }
}
