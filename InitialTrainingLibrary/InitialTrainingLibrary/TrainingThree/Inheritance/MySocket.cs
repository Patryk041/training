using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.TrainingThree.Inheritance
{
    class MySocket : Socket
    {
        public MySocket(SocketType socketType, ProtocolType protocolType) : base(socketType, protocolType)
        {
        }

        public MySocket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) : base(addressFamily, socketType, protocolType)
        {
        }

        public MySocket(SocketInformation socketInformation) : base(socketInformation)
        {
        }

        public void test()
        {
            //this.
        }
    }
}
