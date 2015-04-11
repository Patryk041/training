using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Abstract_Class;

namespace Toci.TraininigLibrary.Developers.R4D3K.OMR.Service
{
    public class Service : ServiceBase
    {
        public Service(int id, string name, decimal cost) : base(id, name, cost)
        {
            this.Id = id;
            this.Name = name;
            this.Cost = cost;
        }
    }
}
