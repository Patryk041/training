using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Koziu.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.Koziu.OMR
{
    public class Room : IRoom
    {
       
        public int Number { get; set; }
        public bool Status { get; set; }

<<<<<<< HEAD:InitialTrainingLibrary/Toci.TraininigLibrary/Developers/Koziu/OMR/Room.cs
        public List<IModule> ModuleList
=======
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


        public abstract int GetSize();


        public int Widht
>>>>>>> be0099251d400d27461618206d512626c8c311a2:InitialTrainingLibrary/Toci.TraininigLibrary/Developers/Koziu/OMR/BedBase.cs
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


        public List<IBed> BedsList
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
