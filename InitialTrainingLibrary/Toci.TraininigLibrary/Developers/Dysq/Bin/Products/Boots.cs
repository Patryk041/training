using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Interfaces.InternetStore;


namespace Toci.TraininigLibrary.Developers.Dysq.Bin.Products
{
    public class Boots
    {
        protected int ProductId { get; set; }
        protected BootsKind Name { get; set; }
        protected double Price { get; set; }
        protected bool Discount { get; set; }
        protected double Size { get; set; }

    }
}
