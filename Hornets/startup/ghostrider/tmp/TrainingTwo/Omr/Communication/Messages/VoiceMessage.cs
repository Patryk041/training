using System.Collections;
using System.IO;
using System.Runtime.Remoting.Messaging;
using Toci.Hornets.GhostRider.TrainingTwo.Omr.Communication.Interfaces;

namespace Toci.Hornets.GhostRider.TrainingTwo.Omr.Communication.Messages
{
    public class VoiceMessage : ICommunicationMessage
    {
        public string GetMessage(string path)
        {
           // StreamReader str = new StreamReader();
            //logika pobierajaca voice i konwertujaca
            //aac amr mp3 wav

            return null;
        }

        public string GetMessage()
        {
            throw new System.NotImplementedException();
        }
    }
}