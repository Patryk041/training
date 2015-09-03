using Toci.Hornets.GhostRider.ClassObjectStatic.MicrosoftWordSimpleExample;

namespace Toci.Hornets.GhostRider.ClassObjectStatic
{
    public class Demonstration
    {
        private int _zmienna;

        public void ShowMeHowTo(
            string pathToFile, 
            string message, 
            string senderNick, 
            string receiverNick, 
            int time,
            string colour,
            string nowy)
        {
            
        }

        public void ShowMeHowTo(FbChatMessageContainer messageContainer, Demonstration innyobiekt)
        {
            //this.zmienna = "dfsa";
            innyobiekt._zmienna = 5;
            this._zmienna = 6;

            //innyobiekt.ShowMeHowTo(messageContainer, innyobiekt);

            this.ShowMeHowTo(new FbChatMessageContainer(), new Demonstration());

            messageContainer.Transform("hrfewuitgewuitew");
            messageContainer.Transform(messageContainer.message);

            FbChatMessageContainer instancja = new FbChatMessageContainer();
            FbChatMessageContainer sesnownanazwa = new FbChatMessageContainer();
            FbChatMessageContainer instancja2= new FbChatMessageContainer();
            FbChatMessageContainer instancja4 = new FbChatMessageContainer();
            FbChatMessageContainer instancja6 = new FbChatMessageContainer();

            SaveFile sf = new SaveFile();

            sesnownanazwa.time = 7;

            StaticClassExample.cos = 8;

            bool result = sf.SaveContent("", "", instancja);// true ?

            instancja.message = "wartosc";

            sesnownanazwa.message = "dsfafasd";

            //StaticClassExample ins = new StaticClassExample();
            StaticClassExample.metoda();
            

        }
    }
}