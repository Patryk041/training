namespace Toci.Hornets.GhostRider.ClassObjectStatic
{
    public class FbChatMessageContainer
    {
        public string pathToFile;
        public string message;
        public string senderNick;
        public string receiverNick;
        public int time;
        public string colour;
        public string nowyelement;

        public string Transform(string whatever)
        {
            return whatever.Substring(8);
        }
    }
}