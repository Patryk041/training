using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Koziu.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.Koziu.OMR
{
    public abstract class BedBase : IBed
    {

        public string Name
        {
            get;
            set;
        }

        public int MaxAdults
        {
            get;
            set ;                 
        }             

        public BedKind kind
        {
            get;
            set;
        }


        public abstract int GetSize()
        {
            return 0;
        }


        public int Widht
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Height
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
