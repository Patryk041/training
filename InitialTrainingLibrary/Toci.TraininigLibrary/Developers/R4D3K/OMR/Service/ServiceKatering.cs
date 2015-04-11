using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.R4D3K.OMR.Service
{
    public class ServiceKatering : Service
    {
        public ServiceKatering(int id, string name, decimal cost) : base(id, name, cost)
        {
            this.Id = id;
            this.Name = name;
            this.Cost = cost;
            this.KindService = KindOfService.Katering;
        }
    }
}
