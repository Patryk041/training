using System;

namespace Toci.Hornets.GhostRider.TrainingSeven.Mvc
{
    public class Routing
    {
        // account/home

        public void test()
        {
            // caly adre account/home?szukaj=fasdf
            string text = "account/home";
            string query = "?szukaj=fasdf";

            var result = text.Split(new [] {"/"}, StringSplitOptions.None);


        }
    }
}