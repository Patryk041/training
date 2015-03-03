using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;

namespace Toci.TraininigLibrary.Developers.Domi
{
   public class DomiFileEntity : FileEntityBase
    {

       public override string ToString()
       {
           return base.ToString();
       }

       public override string GetLine()
       {
           return base.GetLine(); 
       }
    }
}
