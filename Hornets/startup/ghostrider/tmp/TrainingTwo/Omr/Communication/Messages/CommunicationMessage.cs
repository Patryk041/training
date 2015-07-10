using System.IO;
using Toci.Hornets.GhostRider.TrainingTwo.Omr.Communication.Interfaces;

namespace Toci.Hornets.GhostRider.TrainingTwo.Omr.Communication.Messages
{
    public abstract class CommunicationMessage : ICommunicationMessage
    {
        public abstract string GetMessage();

        protected StreamReader GetStream(string path)
        {
            return null;
        }
    }
}