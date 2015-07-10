using System;
using System.Collections.Generic;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Gliwice.Didi.TelephoneTask
{
    public class GetMessageClass : TelephoneInterpreter
    {
        private string _myName;
        private Dictionary<int, ITelephoneCommunication> _typeMessageDictionary; 
 
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            _typeMessageDictionary = new Dictionary<int, ITelephoneCommunication>()
            {
                {1, new PhotoCommunication()},
                {2, new SmsCommunication()},
                {3, new VoiceCommunication()}
            };

            if (_typeMessageDictionary.ContainsKey(chosenOption))
            {
                return _typeMessageDictionary[chosenOption];
            }
            return null; 
        }

        protected override string MyNick()
        {
            _myName = "Hello I am Didi more nasty than nice!";
            return _myName; 
        }
    }
}